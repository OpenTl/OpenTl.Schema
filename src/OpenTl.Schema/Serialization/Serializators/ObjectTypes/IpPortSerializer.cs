namespace OpenTl.Schema.Serialization.Serializators.ObjectTypes
{
    using System.Reflection;

    using DotNetty.Buffers;

    using OpenTl.Schema.Serialization.Serializators.Interfaces;

    internal class IpPortSerializer : ISerializator
    {
        public TypeInfo SupportedType { get; } = typeof(TIpPort).GetTypeInfo();

        public object Deserialize(IByteBuffer buffer, SerializationMetadata metadata)
        {
            var ipPort = new TIpPort
                         {
                             Ipv4 = buffer.ReadIntLE(),
                             Port = buffer.ReadIntLE()
                         };

            return ipPort;
        }

        public void Serialize(object value, IByteBuffer buffer, SerializationMetadata metadata)
        {
            var ipPort = (TIpPort)value;

            buffer.WriteIntLE(ipPort.Ipv4);
            buffer.WriteIntLE(ipPort.Port);
        }
    }
}