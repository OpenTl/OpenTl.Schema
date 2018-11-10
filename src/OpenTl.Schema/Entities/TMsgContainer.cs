namespace OpenTl.Schema
{
    using OpenTl.Schema.Serialization.Attributes;

    [System.Serializable]
    [Serialize(0x73f1f8dc)]
    public sealed class MsgContainer: IObject
    {
        [SerializationOrder(0)]
        public TContainerMessage[] Messages { get; set; }
    }
}