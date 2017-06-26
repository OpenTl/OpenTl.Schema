// ReSharper disable All

namespace OpenTl.Schema.Phone
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x17d54f61)]
    public class RequestReceivedCall : IRequest<bool>
    {
       [SerializationOrder(0)]
       public IInputPhoneCall Peer {get; set;}

    }
}
