// ReSharper disable All

namespace OpenTl.Schema.Phone
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5b95b3d4)]
    public sealed class RequestRequestCall : IRequest<OpenTl.Schema.Phone.IPhoneCall>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputUser UserId {get; set;}

       [SerializationOrder(1)]
       public int RandomId {get; set;}

       [SerializationOrder(2)]
       public byte[] GAHash {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.IPhoneCallProtocol Protocol {get; set;}

    }
}
