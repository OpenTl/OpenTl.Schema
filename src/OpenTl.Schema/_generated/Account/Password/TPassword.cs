// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7c18141c)]
	public class TPassword : IPassword
	{
       [SerializationArrayLength(-1)]
       [SerializationOrder(0)]
       public byte[] CurrentSalt {get; set;}

       [SerializationArrayLength(-1)]
       [SerializationOrder(1)]
       public byte[] NewSalt {get; set;}

       [SerializationOrder(2)]
       public string Hint {get; set;}

       [SerializationOrder(3)]
       public bool HasRecovery {get; set;}

       [SerializationOrder(4)]
       public string EmailUnconfirmedPattern {get; set;}

	}
}
