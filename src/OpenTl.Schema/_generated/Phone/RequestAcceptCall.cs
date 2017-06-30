// ReSharper disable All

namespace OpenTl.Schema.Phone
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3bd2b4a0)]
    public class RequestAcceptCall : IRequest<Phone.IPhoneCall>
    {
       [SerializationOrder(0)]
       public IInputPhoneCall Peer {get; set;}

       [SerializationOrder(1)]
       public byte[] GB {get; set;}

       [SerializationOrder(2)]
       public IPhoneCallProtocol Protocol {get; set;}

    }
}
