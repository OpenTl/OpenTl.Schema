namespace OpenTl.Schema.Serialization.Serializators.ObjectTypes
{
    using System;
    using System.Collections;
    using System.Reflection;

    using DotNetty.Buffers;

    using OpenTl.Schema.Serialization.Serializators.Interfaces;

    internal class VectorSerializer : ISerializator
    {
        private static readonly uint VectorId;
        
        public TypeInfo SupportedType { get; } = typeof(TVector<>).GetTypeInfo();

        static VectorSerializer()
        {
            SerializationMap.GetIdByType(typeof(TVector<>).GetTypeInfo(), out VectorId);
        }
        
        public object Deserialize(IByteBuffer buffer, SerializationMetadata metadata)
        {
            buffer.SkipBytes(4);
            
            var length = buffer.ReadIntLE();
            var genParameter = metadata.PropertyTypeInfo.GenericTypeArguments[0];
            var vectorType = typeof(TVector<>).MakeGenericType(genParameter);
            var vector = (IList)Activator.CreateInstance(vectorType);
            for (var j = 0; j < length; j++)
            {
                var child = Serializer.Deserialize(buffer, genParameter.GetTypeInfo());
                vector.Add(child);
            }

            return vector;
        }

        public void Serialize(object value, IByteBuffer buffer, SerializationMetadata metadata)
        {
            buffer.WriteIntLE((int)VectorId);

            var collection = (IList)value;
            buffer.WriteIntLE(collection.Count);

            foreach (var item in collection)
            {
                Serializer.Serialize(item, buffer);
            }
        }
    }
}