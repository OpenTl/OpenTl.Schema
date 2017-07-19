namespace OpenTl.Schema
{
    using OpenTl.Schema.Serialization.Attributes;

    [Serialize(0x73f1f8dc)]
    public class TMsgContainer: IObject
    {
        [SerializationOrder(0)]
        public TVector<TContainerMessage> Messages { get; set; }
    }
}