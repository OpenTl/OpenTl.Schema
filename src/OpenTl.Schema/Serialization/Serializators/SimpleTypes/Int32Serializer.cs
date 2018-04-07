namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    using System.Reflection;

    using DotNetty.Buffers;

    using OpenTl.Schema.Serialization.Serializators.Interfaces;

    internal class Int32Serializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(int).GetTypeInfo();

        public object Deserialize(IByteBuffer buffer, SerializationMetadata metadata)
        {
            return buffer.ReadIntLE();
        }

        public void Serialize(object value, IByteBuffer buffer, SerializationMetadata metadata)
        {
            buffer.WriteIntLE((int)value);
        }
    }
}