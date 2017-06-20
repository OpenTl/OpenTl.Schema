using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    internal class UInt64Serializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(ulong).GetTypeInfo();

        public void Serialize(BinaryWriter writer, object value, SerializationMetadata metadata) => writer.Write((ulong) value);

        public object Deserialize(BinaryReader reader, SerializationMetadata metadata) => reader.ReadUInt64();
    }
}