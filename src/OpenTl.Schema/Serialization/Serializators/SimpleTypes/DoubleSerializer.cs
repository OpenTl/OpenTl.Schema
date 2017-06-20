using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    internal class DoubleSerializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(double).GetTypeInfo();

        public void Serialize(BinaryWriter writer, object value, SerializationMetadata metadata) => writer.Write((double) value);

        public object Deserialize(BinaryReader reader, SerializationMetadata metadata) => reader.ReadDouble();
    }
}