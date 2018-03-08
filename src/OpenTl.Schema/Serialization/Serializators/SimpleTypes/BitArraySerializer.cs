using System.Collections;
using System.IO;
using System.Reflection;
using OpenTl.Schema.Serialization.Serializators.Interfaces;

namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    using DotNetty.Buffers;

    internal class BitArraySerializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(BitArray).GetTypeInfo();

        public void Serialize(IByteBuffer buffer, object value, SerializationMetadata metadata)
        {
            var bitArray = (BitArray) value;
            
            var data = new byte[(bitArray.Length - 1) / 8 + 1];
            
            ((ICollection) bitArray).CopyTo(data, 0);
            
            buffer.WriteBytes(data);
        }

        public object Deserialize(IByteBuffer buffer, SerializationMetadata metadata)
        {
            var data = new byte[4];
            
            buffer.ReadBytes(data);
            
            return new BitArray(data);
        }
    }
}