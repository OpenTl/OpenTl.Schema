namespace OpenTl.Schema.Serialization.Serializators.ObjectTypes
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using DotNetty.Buffers;

    using OpenTl.Schema.Serialization.Attributes;
    using OpenTl.Schema.Serialization.Serializators.Interfaces;

    // ReSharper disable once InconsistentNaming
    internal class IObjectSerializer : ISerializator
    {
        private static readonly TNull Null = new TNull();

        private static readonly TypeInfo NullTypeInfo = Null.GetType().GetTypeInfo();

        private static readonly Dictionary<TypeInfo, SerializationMetadata[]> TypesMetadata = new Dictionary<TypeInfo, SerializationMetadata[]>();

        public TypeInfo SupportedType { get; } = typeof(IObject).GetTypeInfo();

        public object Deserialize(IByteBuffer buffer, SerializationMetadata typeMetadata)
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

            var customObjectSerializer = SerializationMap.GetSerializator(typeInfo);
            if (customObjectSerializer != null && !Equals(customObjectSerializer.SupportedType, SupportedType))
            {
                return customObjectSerializer.Deserialize(buffer, typeMetadata);
            }

            var metadatas = GetMetadatas(typeInfo);

            var typeForCreate = (typeMetadata != null && typeInfo.IsGenericType && typeInfo.IsClass
                                     ? typeMetadata.PropertyTypeInfo
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

                var value = Serializer.Deserialize(buffer, metadata);
                metadata.PropertyInfo.SetValue(obj, value);
            }

            return (IObject)obj;
        }

        public void Serialize(object obj, IByteBuffer buffer, SerializationMetadata _)
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

                    Serializer.Serialize(value, buffer, metadata);
                }
            }
            else
            {
                throw new NotSupportedException();
            }
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

            if (!TypesMetadata.TryGetValue(typeInfo, out var meta))
            {
                lock (TypesMetadata)
                {
                    if (!TypesMetadata.TryGetValue(typeInfo, out meta))
                    {
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
                    }
                }
            }

            return meta;
        }

        // public object Deserialize(IByteBuffer buffer, SerializationMetadata metadata)
        // {
        //     var value = Serializer.DeserializeByType(buffer, metadata?.PropertyTypeInfo);

        // //     var valueType = value.GetType().GetTypeInfo();

        // //     if (IsAssignableToGenericType(valueType, typeof(TVector<>)))
        //     {
        //         var length = buffer.ReadIntLE();
        //         var genParameter = metadata.PropertyTypeInfo.GenericTypeArguments[0];
        //         var listType = typeof(List<>).MakeGenericType(genParameter);
        //         var children = (IList)Activator.CreateInstance(listType);
        //         for (var j = 0; j < length; j++)
        //         {
        //             var child = Serializer.DeserializeByType(buffer, genParameter.GetTypeInfo());
        //             children.Add(child);
        //         }

        // //         valueType.GetProperty("Items").SetValue(value, children);
        //     }

        // //     if (value is IBool)
        //     {
        //         return value is TBoolTrue;
        //     }

        // //     return value;
        // }

        // // public static bool IsAssignableToGenericType(TypeInfo givenType, Type genericType)
        // {
        //     var interfaceTypes = givenType.GetInterfaces().Select(it => it.GetTypeInfo());

        // //     if (interfaceTypes.Any(it => it.IsGenericType && it.GetGenericTypeDefinition() == genericType))
        //     {
        //         return true;
        //     }

        // //     if (givenType.IsGenericType && givenType.GetGenericTypeDefinition() == genericType)
        //     {
        //         return true;
        //     }

        // //     var baseType = givenType.BaseType;
        //     return baseType != null && IsAssignableToGenericType(baseType.GetTypeInfo(), genericType);
        // }

        // // public void Serialize(IByteBuffer buffer, object value, SerializationMetadata metadata)
        // {
        //     Serializer.Serialize(value, buffer);

        // //     if (IsAssignableToGenericType(value.GetType().GetTypeInfo(), typeof(TVector<>)))
        //     {
        //         var collection = (ICollection)((dynamic)value).Items;
        //         buffer.WriteIntLE(collection.Count);

        // //         foreach (var item in collection)
        //         {
        //             Serializer.Serialize(item, buffer);
        //         }
        //     }
        // }
    }
}