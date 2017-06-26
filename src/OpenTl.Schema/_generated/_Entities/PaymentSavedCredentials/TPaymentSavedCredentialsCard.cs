// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcdc27a1f)]
	public class TPaymentSavedCredentialsCard : IPaymentSavedCredentials
	{
       [SerializationOrder(0)]
       public string Id {get; set;}

       [SerializationOrder(1)]
       public string Title {get; set;}

	}
}
