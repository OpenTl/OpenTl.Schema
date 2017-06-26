// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x137948a5)]
	public class TPasswordRecovery : IPasswordRecovery
	{
       [SerializationOrder(0)]
       public string EmailPattern {get; set;}

	}
}
