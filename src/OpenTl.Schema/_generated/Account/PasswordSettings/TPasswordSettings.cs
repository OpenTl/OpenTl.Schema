namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb7b72ab3)]
	public class TPasswordSettings : IPasswordSettings
	{
       [SerializationOrder(0)]
       public string Email {get; set;}

	}
}
