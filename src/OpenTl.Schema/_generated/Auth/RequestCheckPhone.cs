// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6fe51dfb)]
    public class RequestCheckPhone : IRequest<Auth.ICheckedPhone>
    {
       [SerializationOrder(0)]
       public string PhoneNumber {get; set;}

    }
}
