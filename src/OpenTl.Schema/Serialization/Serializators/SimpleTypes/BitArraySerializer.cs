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
            var data = new byte[(bitArray.Length - 1) / 8 + 1];
            ((ICollection) bitArray).CopyTo(data, 0);
            writer.Write(data);
        }

        public object Deserialize(BinaryReader reader, SerializationMetadata metadata) => new BitArray(reader.ReadBytes(4));
    }
}