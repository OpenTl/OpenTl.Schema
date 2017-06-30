﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using OpenTl.Schema.Serialization.Attributes;
 using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization
{
    public static class Serializer
    {
        private static readonly Dictionary<TypeInfo, SerializationMetadata[]> TypesMetadata = new Dictionary<TypeInfo, SerializationMetadata[]>();

        private static readonly TNull Null = new TNull();
    
        private static readonly TypeInfo NullTypeInfo = Null.GetType().GetTypeInfo();

        public static IObject DeserializeObject(byte[] bytes)
        {
            using (var stream = new MemoryStream(bytes))
            using (var binaryReader = new BinaryReader(stream))
            {
                return DeserializeObject(binaryReader);
            }
        }

        public static IObject DeserializeObject(BinaryReader reader)
        {
            return DeserializeObject(reader, null);
        }
        
        internal static object Deserialize(BinaryReader binaryReader, TypeInfo typeInfo)
        {
            if (typeInfo == null || typeof(IObject).GetTypeInfo().IsAssignableFrom(typeInfo))
            {
                return DeserializeObject(binaryReader, typeInfo);
            }

            var serializator = SerializationMap.GetSerializator(typeInfo);
            return serializator.Deserialize(binaryReader, null);
        }

        private static IObject DeserializeObject(BinaryReader reader, TypeInfo propertyTypeInfo)
        {
            var id = reader.ReadUInt32();

            if (!SerializationMap.GetTypeById(id, out var typeInfo))
            {
                throw new NotSupportedException();
            }
                
            if (Equals(typeInfo, NullTypeInfo))
            {
                return null;
            }
            
            var metadatas = GetMetadatas(typeInfo);

            var typeForCreate = ( propertyTypeInfo != null && propertyTypeInfo.IsClass ? propertyTypeInfo : typeInfo).AsType();
            var obj = Activator.CreateInstance(typeForCreate);
            foreach (var metadata in metadatas)
            {
                if (metadata.CanSerializeIndex.HasValue)
                {
                    var flags = (BitArray)metadata.CanSerializeSource.GetValue(obj);
                    if (!flags[metadata.CanSerializeIndex.Value])
                    {
                        continue; 
                    }
                }

                if (metadata.FromFlagIndex.HasValue)
                {
                    var flags = (BitArray) metadata.FromFlagSource.GetValue(obj);
                    var flagValue = flags[metadata.FromFlagIndex.Value];
                    metadata.PropertyInfo.SetValue(obj, flagValue);
                    
                    continue;
                }

                var serializator =  SerializationMap.GetSerializator(metadata.PropertyTypeInfo);
                
                var value = serializator.Deserialize(reader, metadata);
                metadata.PropertyInfo.SetValue(obj, value);
            }

            return (IObject) obj;
        }
        
        public static byte[] SerializeObject(object obj)
        {
            using (var stream = new MemoryStream())
            using (var binaryWriter = new BinaryWriter(stream))
            {
                Serialize(obj, binaryWriter);

                stream.TryGetBuffer(out var buffer);
                return buffer.Array;
            }
        }

        internal static void Serialize(object obj, BinaryWriter binaryWriter)
        {
            if (obj == null)
                obj = Null;

            var objectType = obj.GetType().GetTypeInfo();
            
            
            if (SerializationMap.GetIdByType(objectType, out var typeId))
            {
                binaryWriter.Write(typeId);
            
                var metadatas = GetMetadatas(objectType);

                ComputeFlags(obj, metadatas);

                Serialize(binaryWriter, obj);                
            }
            else
            {
                SerializeValue(binaryWriter, obj, null);
            }
            
        }

        private static object Serialize(BinaryWriter binaryWriter, object obj)
        {
            var metadatas = GetMetadatas(obj.GetType().GetTypeInfo());

            foreach (var metadata in metadatas)
            {
                var value = metadata.PropertyInfo.GetValue(obj);

                if (metadata.CanSerializeIndex.HasValue)
                {
                    var flags = (BitArray) metadata.CanSerializeSource.GetValue(obj);
                    if (!flags[metadata.CanSerializeIndex.Value])
                    {
                        continue;
                    }
                }

                if (metadata.FromFlagIndex.HasValue)
                {
                    var flags = (BitArray) metadata.FromFlagSource.GetValue(obj);
                    flags[metadata.FromFlagIndex.Value] = (bool) value;
                 
                    continue;
                }

                SerializeValue(binaryWriter, value, metadata);
            }

            return obj;
        }

        private static void SerializeValue(BinaryWriter binaryWriter, object value, SerializationMetadata metadata)
        {
            ISerializator ser;
            if (value != null)
            {
                ser = SerializationMap.GetSerializator(value.GetType().GetTypeInfo());
            }
            else
            {
                value = Null;
                ser = SerializationMap.GetSerializator(NullTypeInfo);
            }


            ser.Serialize(binaryWriter, value, metadata);
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