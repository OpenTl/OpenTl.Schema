// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbcd51581)]
    public class RequestSignIn : IRequest<Auth.IAuthorization>
    {
       [SerializationOrder(0)]
       public string PhoneNumber {get; set;}

       [SerializationOrder(1)]
       public string PhoneCodeHash {get; set;}

       [SerializationOrder(2)]
       public string PhoneCode {get; set;}

    }
}
