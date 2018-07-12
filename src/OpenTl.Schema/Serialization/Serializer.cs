using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization
{
    using System;
    using System.Reflection;

    using DotNetty.Buffers;

    public static class Serializer
    {
        private static readonly uint TgZipPackageId;
        
        static Serializer()
        {
            SerializationMap.GetIdByType(typeof(TgZipPacked).GetTypeInfo(), out TgZipPackageId);
        }
        
        public static IObject Deserialize(IByteBuffer buffer)
        {
            return (IObject)Deserialize(buffer, typeof(IObject).GetTypeInfo());
        }

        public static object Deserialize(IByteBuffer buffer, Type expectedType)
        {
            return expectedType == null
                       ? Deserialize(buffer)
                       : Deserialize(buffer, new SerializationMetadata { PropertyTypeInfo = expectedType.GetTypeInfo() });
        }
        
        public static IByteBuffer Serialize(object obj)
        {
            var buffer = PooledByteBufferAllocator.Default.Buffer();

            Serialize(obj, buffer);

            return buffer;
        }

        // ReSharper disable once MethodOverloadWithOptionalParameter
        internal static object Deserialize(IByteBuffer buffer, SerializationMetadata metadata)
        {
            if (metadata != null)
            {
                ISerializator ser;
                if (buffer.GetUnsignedIntLE(buffer.ReaderIndex) == TgZipPackageId)
                {
                    buffer.SkipBytes(4);
                    ser = SerializationMap.GetSerializator(typeof(TgZipPacked).GetTypeInfo());
                }
                else
                {
                    ser = SerializationMap.GetSerializator(metadata.PropertyTypeInfo);
                }
                return ser.Deserialize(buffer, metadata);
            }

            return Deserialize(buffer, typeof(IObject).GetTypeInfo());
        }

        internal static object Deserialize(IByteBuffer buffer, TypeInfo typeInfo)
        {
            var ser = SerializationMap.GetSerializator(typeInfo);
            return ser.Deserialize(buffer, null);
        }

        internal static void Serialize(object obj, IByteBuffer buffer, SerializationMetadata metadata = null)
        {
            var ser = SerializationMap.GetSerializator(obj.GetType().GetTypeInfo());
            ser.Serialize(obj, buffer, metadata);
        }
    }
}