namespace OpenTl.Schema
{
    using OpenTl.Schema.Serialization.Attributes;

    public sealed class TContainerMessage
    {
        [SerializationOrder(0)]
        public long MsgId { get; set; }
        
        [SerializationOrder(1)]
        public int SeqNo { get; set; }
        
        [SerializationOrder(2)]
        public int Bytes { get; set; }
        
        [SerializationOrder(3)]
        public IObject Body { get; set; }
    }
}