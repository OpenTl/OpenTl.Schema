// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x771c1d97)]
    public class RequestSendInvites : IRequest<bool>
    {
       [SerializationOrder(0)]
       public TVector<string> PhoneNumbers {get; set;}

       [SerializationOrder(1)]
       public string Message {get; set;}

    }
}
