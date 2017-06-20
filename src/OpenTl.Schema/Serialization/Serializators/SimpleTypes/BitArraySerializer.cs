using System.Collections;
using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    internal class BitArraySerializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(BitArray).GetTypeInfo();

        public void Serialize(BinaryWriter writer, object value, SerializationMetadata metadata)
        {
            var bitArray = (BitArray) value;
            for (var j = 0; j < 32; j++)
            {
                writer.Write(bitArray[j]);
            }
        }

        public object Deserialize(BinaryReader reader, SerializationMetadata metadata) => new BitArray(reader.ReadBytes(4));
    }
}