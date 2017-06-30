namespace OpenTl.Schema.Entities
{
    using OpenTl.Schema.Serialization.Attributes;

    public class TContainerMessage: IObject
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