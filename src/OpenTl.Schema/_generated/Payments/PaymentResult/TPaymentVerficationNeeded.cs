namespace OpenTl.Schema.Payments
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6b56b921)]
	public class TPaymentVerficationNeeded : IPaymentResult
	{
       [SerializationOrder(0)]
       public string Url {get; set;}

	}
}
