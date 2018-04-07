namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    using System.Reflection;

    using DotNetty.Buffers;

    using OpenTl.Schema.Serialization.Serializators.Interfaces;

    internal class Int64Serializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(long).GetTypeInfo();

        public object Deserialize(IByteBuffer buffer, SerializationMetadata metadata)
        {
            return buffer.ReadLongLE();
        }

        public void Serialize(object value, IByteBuffer buffer, SerializationMetadata metadata)
        {
            buffer.WriteLongLE((long)value);
        }
    }
}