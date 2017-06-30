// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xdb64fd34)]
	public class TTmpPassword : ITmpPassword
	{
       [SerializationOrder(0)]
       public byte[] MpPassword {get; set;}

       [SerializationOrder(1)]
       public int ValidUntil {get; set;}

	}
}
