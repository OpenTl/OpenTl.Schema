namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    using System.Reflection;

    using DotNetty.Buffers;

    using OpenTl.Schema.Serialization.Serializators.Interfaces;

    internal class DoubleSerializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(double).GetTypeInfo();

        public object Deserialize(IByteBuffer buffer, SerializationMetadata metadata)
        {
            return buffer.ReadDoubleLE();
        }

        public void Serialize(object value, IByteBuffer buffer, SerializationMetadata metadata)
        {
            buffer.WriteDoubleLE((double)value);
        }
    }
}