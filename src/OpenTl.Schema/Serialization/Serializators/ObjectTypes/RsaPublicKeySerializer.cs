namespace OpenTl.Schema.Serialization.Serializators.ObjectTypes
{
    using System.Reflection;

    using DotNetty.Buffers;

    using OpenTl.Schema.Serialization.Serializators.Interfaces;

    internal class RsaPublicKeySerializer : ISerializator
    {
        private static readonly TypeInfo ArrayOfBytesTypeInfo = typeof(byte[]).GetTypeInfo();

        public TypeInfo SupportedType { get; } = typeof(TRsaPublicKey).GetTypeInfo();

        public object Deserialize(IByteBuffer buffer, SerializationMetadata metadata)
        {
            var rsaPublicKey = new TRsaPublicKey
                               {
                                   N = (byte[])Serializer.Deserialize(buffer, ArrayOfBytesTypeInfo),
                                   E = (byte[])Serializer.Deserialize(buffer, ArrayOfBytesTypeInfo)
                               };

            return rsaPublicKey;
        }

        public void Serialize(object value, IByteBuffer buffer, SerializationMetadata metadata)
        {
            var rsaPublicKey = (TRsaPublicKey)value;

            Serializer.Serialize(rsaPublicKey.N, buffer);
            Serializer.Serialize(rsaPublicKey.E, buffer);
        }
    }
}