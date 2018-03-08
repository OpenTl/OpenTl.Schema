namespace OpenTl.Schema
{
    using OpenTl.Schema.Serialization.Attributes;

    [Serialize(0xbe7e8ef1)]
    public class RequestReqPqMulty : IRequest<IResPQ>
    {
        [SerializationArrayLength(16)]
        [SerializationOrder(0)]
        public byte[] Nonce {get; set;}
    }
}