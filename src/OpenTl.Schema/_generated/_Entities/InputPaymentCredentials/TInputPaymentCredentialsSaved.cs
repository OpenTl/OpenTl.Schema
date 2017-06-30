// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc10eb2cf)]
	public class TInputPaymentCredentialsSaved : IInputPaymentCredentials
	{
       [SerializationOrder(0)]
       public string Id {get; set;}

       [SerializationOrder(1)]
       public byte[] TmpPassword {get; set;}

	}
}
