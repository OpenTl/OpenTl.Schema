namespace OpenTl.Schema.Entities
{
    using OpenTl.Schema.Serialization.Attributes;

    [Serialize(0x3072cfa1)]
    public class TgZipPacked: IObject
    {
        [SerializationOrder(0)]
        public byte[] PackedData { get; set; }
    }
}