// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3e0bdd7c)]
    public class RequestUpdateUsername : IRequest<IUser>
    {
       [SerializationOrder(0)]
       public string Username {get; set;}

    }
}
