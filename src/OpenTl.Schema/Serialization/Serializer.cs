namespace OpenTl.Schema.Serialization
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using DotNetty.Buffers;

    using OpenTl.Schema.Serialization.Attributes;
    using OpenTl.Schema.Serialization.Serializators.Interfaces;

    public static class Serializer
    {
        private static readonly Dictionary<TypeInfo, SerializationMetadata[]> TypesMetadata = new Dictionary<TypeInfo, SerializationMetadata[]>();

        private static readonly TNull Null = new TNull();

        private static readonly TypeInfo NullTypeInfo = Null.GetType().GetTypeInfo();

        public static IObject Deserialize(IByteBuffer buffer)
        {
            return DeserializeObject(buffer, null);
        }

        public static void Serialize(object obj, IByteBuffer buffer)
        {
            if (obj == null)
            {
                obj = Null;
            }

            var objectType = obj.GetType().GetTypeInfo();

            if (SerializationMap.GetIdByType(objectType, out var typeId))
            {
                buffer.WriteIntLE((int)typeId);

                var metadatas = GetMetadatas(objectType);

                ComputeFlags(obj, metadatas);

                Serialize(buffer, obj);
            }
            else
            {
                SerializeValue(buffer, obj, null);
            }
        }

        internal static object DeserializeByType(IByteBuffer buffer, TypeInfo typeInfo)
        {
            if (typeInfo == null || typeof(IObject).GetTypeInfo().IsAssignableFrom(typeInfo))
            {
                return DeserializeObject(buffer, typeInfo);
            }

            var serializator = SerializationMap.GetSerializator(typeInfo);
            return serializator.Deserialize(buffer, null);
        }

        private static void ComputeFlags(object obj, IReadOnlyList<SerializationMetadata> metadatas)
        {
            var setIndexes = new HashSet<int>();

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

                    if (!setIndexes.Contains(metadata.CanSerializeIndex.Value))
                    {
                        flags[metadata.CanSerializeIndex.Value] = value != null && !value.Equals(GetDefaultValue(metadata.PropertyInfo.PropertyType));

                        setIndexes.Add(metadata.CanSerializeIndex.Value);
                    }
                }

                if (metadata.FromFlagIndex.HasValue)
                {
                    var flags = (BitArray)metadata.FromFlagSource.GetValue(obj);
                    if (flags == null)
                    {
                        flags = new BitArray(32);
                        metadata.FromFlagSource.SetValue(obj, flags);
                    }

                    flags[metadata.FromFlagIndex.Value] = (bool)value;

                    setIndexes.Add(metadata.FromFlagIndex.Value);
                }
            }
        }

        private static IObject DeserializeObject(IByteBuffer buffer, TypeInfo propertyTypeInfo)
        {
            var id = buffer.ReadUnsignedIntLE();

            if (!SerializationMap.GetTypeById(id, out var typeInfo))
            {
                throw new NotSupportedException();
            }

            if (Equals(typeInfo, NullTypeInfo))
            {
                return null;
            }

            var metadatas = GetMetadatas(typeInfo);

            var typeForCreate = (propertyTypeInfo != null && propertyTypeInfo.IsClass
                                     ? propertyTypeInfo
                                     : typeInfo).AsType();
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
                    var flags = (BitArray)metadata.FromFlagSource.GetValue(obj);
                    var flagValue = flags[metadata.FromFlagIndex.Value];
                    metadata.PropertyInfo.SetValue(obj, flagValue);

                    continue;
                }

                var serializator = SerializationMap.GetSerializator(metadata.PropertyTypeInfo);

                var value = serializator.Deserialize(buffer, metadata);
                metadata.PropertyInfo.SetValue(obj, value);
            }

            return (IObject)obj;
        }

        private static object GetDefaultValue(Type t)
        {
            return t.GetTypeInfo().IsValueType
                       ? Activator.CreateInstance(t)
                       : null;
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
                           .Select(
                               info =>
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
                                                                   : null
                                          };
                               })
                           .Where(metadata => metadata.Order.HasValue)
                           .OrderBy(metadata => metadata.Order)
                           .ToArray();

            TypesMetadata.Add(typeInfo, meta);

            return meta;
        }

        private static void Serialize(IByteBuffer buffer, object obj)
        {
            var metadatas = GetMetadatas(obj.GetType().GetTypeInfo());

            foreach (var metadata in metadatas)
            {
                var value = metadata.PropertyInfo.GetValue(obj);

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
                    var flags = (BitArray)metadata.FromFlagSource.GetValue(obj);
                    flags[metadata.FromFlagIndex.Value] = (bool)value;

                    continue;
                }

                SerializeValue(buffer, value, metadata);
            }
        }

        private static void SerializeValue(IByteBuffer buffer, object value, SerializationMetadata metadata)
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

            ser.Serialize(buffer, value, metadata);
        }
    }
}