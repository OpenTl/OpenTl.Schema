using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    using DotNetty.Buffers;

    internal class UInt32Serializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(uint).GetTypeInfo();

        public void Serialize(IByteBuffer buffer, object value, SerializationMetadata metadata) => buffer.WriteIntLE((int)value);

        public object Deserialize(IByteBuffer buffer, SerializationMetadata metadata) => buffer.ReadUnsignedIntLE();
    }
}