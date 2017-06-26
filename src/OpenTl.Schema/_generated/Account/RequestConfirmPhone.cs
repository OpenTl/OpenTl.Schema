// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5f2178c3)]
    public class RequestConfirmPhone : IRequest<bool>
    {
       [SerializationOrder(0)]
       public string PhoneCodeHash {get; set;}

       [SerializationOrder(1)]
       public string PhoneCode {get; set;}

    }
}
