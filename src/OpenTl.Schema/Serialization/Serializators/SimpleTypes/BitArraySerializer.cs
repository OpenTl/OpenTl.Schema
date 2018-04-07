namespace OpenTl.Schema.Serialization.Serializators.SimpleTypes
{
    using System.Collections;
    using System.Reflection;

    using DotNetty.Buffers;

    using OpenTl.Schema.Serialization.Serializators.Interfaces;

    internal class BitArraySerializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(BitArray).GetTypeInfo();

        public object Deserialize(IByteBuffer buffer, SerializationMetadata metadata)
        {
            var data = new byte[4];

            buffer.ReadBytes(data);

            return new BitArray(data);
        }

        public void Serialize(object value, IByteBuffer buffer, SerializationMetadata metadata)
        {
            var bitArray = (BitArray)value;

            var data = new byte[(bitArray.Length - 1) / 8 + 1];

            ((ICollection)bitArray).CopyTo(data, 0);

            buffer.WriteBytes(data);
        }
    }
}