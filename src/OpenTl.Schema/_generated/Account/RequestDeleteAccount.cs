// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x418d4e0b)]
    public class RequestDeleteAccount : IRequest<bool>
    {
       [SerializationOrder(0)]
       public string Reason {get; set;}

    }
}
