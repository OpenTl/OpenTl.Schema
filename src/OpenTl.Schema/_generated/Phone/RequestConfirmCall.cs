// ReSharper disable All

namespace OpenTl.Schema.Phone
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2efe1722)]
    public class RequestConfirmCall : IRequest<Phone.IPhoneCall>
    {
       [SerializationOrder(0)]
       public IInputPhoneCall Peer {get; set;}

       [SerializationOrder(1)]
       public byte[] GA {get; set;}

       [SerializationOrder(2)]
       public long KeyFingerprint {get; set;}

       [SerializationOrder(3)]
       public IPhoneCallProtocol Protocol {get; set;}

    }
}
