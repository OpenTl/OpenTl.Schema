using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    internal class Int64Serializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(long).GetTypeInfo();

        public void Serialize(BinaryWriter writer, object value, SerializationMetadata metadata) => writer.Write((long) value);

        public object Deserialize(BinaryReader reader, SerializationMetadata metadata) => reader.ReadInt64();
    }
}