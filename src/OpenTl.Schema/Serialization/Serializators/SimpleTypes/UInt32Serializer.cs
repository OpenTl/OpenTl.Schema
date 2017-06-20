using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    internal class UInt32Serializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(uint).GetTypeInfo();

        public void Serialize(BinaryWriter writer, object value, SerializationMetadata metadata) => writer.Write((uint) value);

        public object Deserialize(BinaryReader reader, SerializationMetadata metadata) => reader.ReadUInt32();
    }
}