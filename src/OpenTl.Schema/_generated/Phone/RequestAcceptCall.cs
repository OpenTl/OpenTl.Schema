// ReSharper disable All

namespace OpenTl.Schema.Phone
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3bd2b4a0)]
    public sealed class RequestAcceptCall : IRequest<OpenTl.Schema.Phone.IPhoneCall>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPhoneCall Peer {get; set;}

       [SerializationOrder(1)]
       public byte[] GB {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IPhoneCallProtocol Protocol {get; set;}

    }
}
