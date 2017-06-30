// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8f31b327)]
	public class TMessageActionPaymentSentMe : IMessageAction
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public string Currency {get; set;}

       [SerializationOrder(2)]
       public long TotalAmount {get; set;}

       [SerializationOrder(3)]
       public byte[] Payload {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 0)]
       public IPaymentRequestedInfo Info {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 1)]
       public string ShippingOptionId {get; set;}

       [SerializationOrder(6)]
       public IPaymentCharge Charge {get; set;}

	}
}
