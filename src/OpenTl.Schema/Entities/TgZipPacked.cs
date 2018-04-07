namespace OpenTl.Schema
{
    using OpenTl.Schema.Serialization.Attributes;

    [Serialize(0x3072cfa1)]
    public sealed class TgZipPacked: IObject
    {
        [SerializationOrder(0)]
        public byte[] PackedData { get; set; }
    }
}