using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    using DotNetty.Buffers;

    internal class Int64Serializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(long).GetTypeInfo();

        public void Serialize(IByteBuffer buffer, object value, SerializationMetadata metadata) => buffer.WriteLongLE((long) value);

        public object Deserialize(IByteBuffer buffer, SerializationMetadata metadata) => buffer.ReadLongLE();
    }
}