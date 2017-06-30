// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5d2f3aa9)]
	public class TUpdateBotPrecheckoutQuery : IUpdate
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public long QueryId {get; set;}

       [SerializationOrder(2)]
       public int UserId {get; set;}

       [SerializationOrder(3)]
       public byte[] Payload {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 0)]
       public IPaymentRequestedInfo Info {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 1)]
       public string ShippingOptionId {get; set;}

       [SerializationOrder(6)]
       public string Currency {get; set;}

       [SerializationOrder(7)]
       public long TotalAmount {get; set;}

	}
}
