using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    using DotNetty.Buffers;

    internal class DoubleSerializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(double).GetTypeInfo();

        public void Serialize(IByteBuffer buffer, object value, SerializationMetadata metadata) => buffer.WriteDoubleLE((double) value);

        public object Deserialize(IByteBuffer buffer, SerializationMetadata metadata) => buffer.ReadDoubleLE();
    }
}