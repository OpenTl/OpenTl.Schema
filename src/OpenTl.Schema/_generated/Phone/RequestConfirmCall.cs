// ReSharper disable All

namespace OpenTl.Schema.Phone
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2efe1722)]
    public sealed class RequestConfirmCall : IRequest<OpenTl.Schema.Phone.IPhoneCall>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPhoneCall Peer {get; set;}

       [SerializationOrder(1)]
       public byte[] GA {get; set;}

       [SerializationOrder(2)]
       public long KeyFingerprint {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.IPhoneCallProtocol Protocol {get; set;}

    }
}
