﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using OpenTl.Schema.Serialization.Attributes;

namespace OpenTl.Schema.Serialization
{
    public static class Serializer
    {
        private static readonly Dictionary<TypeInfo, SerializationMetadata[]> TypesMetadata = new Dictionary<TypeInfo, SerializationMetadata[]>();

        public static IObject DeserializeObject(byte[] bytes)
        {
            using (var stream = new MemoryStream(bytes))
            using (var binaryReader = new BinaryReader(stream))
            {
                return Deserialize(binaryReader);
            }
        }

        internal static IObject Deserialize(BinaryReader binaryReader)
        {
            var id = binaryReader.ReadUInt32();

            if (!SerializationMap.GetTypeById(id, out var typeInfo))
            {
                throw new NotSupportedException();
            }

            return (IObject) Deserialize(binaryReader, typeInfo);
        }

        private static object Deserialize(BinaryReader reader, TypeInfo typeInfo)
        {
            var metadatas = GetMetadatas(typeInfo);

            if (metadatas == null)
            {
                var serializator =  SerializationMap.GetSerializator(typeInfo);
                return serializator.Deserialize(reader, null);
            }
            
            var obj = Activator.CreateInstance(typeInfo.AsType());
            foreach (var metadata in metadatas)
            {
                var serializator =  SerializationMap.GetSerializator(metadata.PropertyTypeInfo);
                
                var value = serializator.Deserialize(reader, metadata);
                metadata.PropertyInfo.SetValue(obj, value);
            }

            return obj;
        }
        
        public static MemoryStream SerializeObject(object obj)
        {
            var stream = new MemoryStream();
            var binaryWriter = new BinaryWriter(stream);
            Serialize(obj, binaryWriter);

            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }

        private static void Serialize(object obj, BinaryWriter binaryWriter)
        {
            var objectType = obj.GetType().GetTypeInfo();

            if (!SerializationMap.GetIdByType(objectType, out var typeId))
            {
                throw new NotSupportedException();
            }

            binaryWriter.Write(typeId);

            var metadatas = GetMetadatas(objectType);

            ComputeFlags(obj, metadatas);

            Serialize(binaryWriter, obj);
        }

        internal static object Serialize(BinaryWriter binaryWriter, object obj)
        {
            var metadatas = GetMetadatas(obj.GetType().GetTypeInfo());

            foreach (var metadata in metadatas)
            {
                var serializator =  SerializationMap.GetSerializator(metadata.PropertyTypeInfo);

                var value = metadata.PropertyInfo.GetValue(obj);
                
                serializator.Serialize(binaryWriter, value, metadata);
            }

            return obj;
        }

        private static void ComputeFlags(object obj, IReadOnlyList<SerializationMetadata> metadatas)
        {
            // ReSharper disable once ForCanBeConvertedToForeach
            for (var index = 0; index < metadatas.Count; index++)
            {
                var metadata = metadatas[index];
                var value = metadata.PropertyInfo.GetValue(obj);
                if (metadata.CanSerializeIndex.HasValue)
                {
                    var flags = (BitArray)metadata.CanSerializeSource.GetValue(obj);
                    if (flags == null)
                    {
                        flags = new BitArray(32);
                        metadata.CanSerializeSource.SetValue(obj, flags);
                    }

                    flags[metadata.CanSerializeIndex.Value] = value != null && !value.Equals(GetDefaultValue(metadata.PropertyInfo.PropertyType));
                }

                if (metadata.FromFlagIndex.HasValue)
                {
                    var flags = (BitArray)metadata.FromFlagSource.GetValue(obj);
                    if (flags == null)
                    {
                        flags = new BitArray(32);
                        metadata.FromFlagSource.SetValue(obj, flags);
                    }
                    
                    flags[metadata.FromFlagIndex.Value] = (bool) value;
                }
            }
        }

        private static object GetDefaultValue(Type t)
        {
            return t.GetTypeInfo().IsValueType ? Activator.CreateInstance(t) : null;
        }

        private static SerializationMetadata[] GetMetadatas(TypeInfo typeInfo)
        {
            if (!typeof(IObject).GetTypeInfo().IsAssignableFrom(typeInfo))
            {
                return null;
            } 
            
            if (TypesMetadata.TryGetValue(typeInfo, out var meta))
            {
                return meta;
            }

            meta = typeInfo.DeclaredProperties
                .Select(info =>
                {
                    var canSerializeAttribute = info.GetCustomAttribute<CanSerializeAttribute>();
                    var fromFlagAttribute = info.GetCustomAttribute<FromFlagAttribute>();

                    return new SerializationMetadata
                    {
                        PropertyInfo = info,
                        PropertyTypeInfo = info.PropertyType.GetTypeInfo(),
                        Order = info.GetCustomAttribute<SerializationOrderAttribute>()?.Order,
                        ArrayLength = info.GetCustomAttribute<SerializationArrayLengthAttribute>()?.Length,
                        CanSerializeIndex = canSerializeAttribute?.Index,
                        CanSerializeSource = canSerializeAttribute != null
                            ? typeInfo.GetProperty(canSerializeAttribute.PropertyName)
                            : null,
                        FromFlagIndex = fromFlagAttribute?.Index,
                        FromFlagSource = fromFlagAttribute != null
                            ? typeInfo.GetProperty(fromFlagAttribute.PropertyName)
                            : null,
                    };
                })
                .Where(metadata => metadata.Order.HasValue)
                .OrderBy(metadata => metadata.Order)
                .ToArray();
            
            TypesMetadata.Add(typeInfo, meta);

            return meta;
        }
    }
}