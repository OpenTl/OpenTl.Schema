namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    using System.Reflection;

    using DotNetty.Buffers;

    using OpenTl.Schema.Serialization.Serializators.Interfaces;

    internal class UInt64Serializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(ulong).GetTypeInfo();

        public object Deserialize(IByteBuffer buffer, SerializationMetadata metadata)
        {
            return (ulong)buffer.ReadLongLE();
        }

        public void Serialize(object value, IByteBuffer buffer, SerializationMetadata metadata)
        {
            buffer.WriteLongLE((long)value);
        }
    }
}