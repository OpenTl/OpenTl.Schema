// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3ef1a9bf)]
    public class RequestResendCode : IRequest<Auth.ISentCode>
    {
       [SerializationOrder(0)]
       public string PhoneNumber {get; set;}

       [SerializationOrder(1)]
       public string PhoneCodeHash {get; set;}

    }
}
