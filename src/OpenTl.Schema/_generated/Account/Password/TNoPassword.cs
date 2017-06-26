// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x96dabc18)]
	public class TNoPassword : IPassword
	{
       [SerializationArrayLength(-1)]
       [SerializationOrder(0)]
       public byte[] NewSalt {get; set;}

       [SerializationOrder(1)]
       public string EmailUnconfirmedPattern {get; set;}

	}
}
