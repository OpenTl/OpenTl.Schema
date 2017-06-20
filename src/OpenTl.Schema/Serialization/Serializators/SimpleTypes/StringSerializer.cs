using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    internal class StringSerializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(string).GetTypeInfo();

        public void Serialize(BinaryWriter writer, object value, SerializationMetadata metadata) => writer.Write((string) value);

        public object Deserialize(BinaryReader reader, SerializationMetadata metadata) => reader.ReadString();
    }
}