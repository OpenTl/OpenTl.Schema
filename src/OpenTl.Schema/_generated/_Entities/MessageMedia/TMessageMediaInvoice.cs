// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x84551347)]
	public class TMessageMediaInvoice : IMessageMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool ShippingAddressRequested {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 3)]
       public bool Test {get; set;}

       [SerializationOrder(3)]
       public string Title {get; set;}

       [SerializationOrder(4)]
       public string Description {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 0)]
       public IWebDocument Photo {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 2)]
       public int ReceiptMsgId {get; set;}

       [SerializationOrder(7)]
       public string Currency {get; set;}

       [SerializationOrder(8)]
       public long TotalAmount {get; set;}

       [SerializationOrder(9)]
       public string StartParam {get; set;}

	}
}
