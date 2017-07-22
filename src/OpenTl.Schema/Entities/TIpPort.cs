namespace OpenTl.Schema
{
    using OpenTl.Schema.Serialization.Attributes;

    [Serialize]
    public class TIpPort
    {
        [SerializationOrder(1)]
        public int Ipv4 { get; set; }
        
        [SerializationOrder(2)]
        public int Port { get; set; }
    }
}