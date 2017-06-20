namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x40699cd0)]
	public class TMessageActionPaymentSent : IMessageAction
	{
       [SerializationOrder(0)]
       public string Currency {get; set;}

       [SerializationOrder(1)]
       public long TotalAmount {get; set;}

	}
}
