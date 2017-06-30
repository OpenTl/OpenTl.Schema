// ReSharper disable All

namespace OpenTl.Schema.Phone
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5b95b3d4)]
    public class RequestRequestCall : IRequest<Phone.IPhoneCall>
    {
       [SerializationOrder(0)]
       public IInputUser UserId {get; set;}

       [SerializationOrder(1)]
       public int RandomId {get; set;}

       [SerializationOrder(2)]
       public byte[] GAHash {get; set;}

       [SerializationOrder(3)]
       public IPhoneCallProtocol Protocol {get; set;}

    }
}
