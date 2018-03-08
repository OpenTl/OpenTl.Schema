using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    using DotNetty.Buffers;

    internal class UInt64Serializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(ulong).GetTypeInfo();

        public void Serialize(IByteBuffer buffer, object value, SerializationMetadata metadata) => buffer.WriteLongLE((long) value);

        public object Deserialize(IByteBuffer buffer, SerializationMetadata metadata) => (ulong)buffer.ReadLongLE();
    }
}