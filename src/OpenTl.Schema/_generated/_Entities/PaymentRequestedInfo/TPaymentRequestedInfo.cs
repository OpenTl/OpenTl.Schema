// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x909c3f94)]
	public class TPaymentRequestedInfo : IPaymentRequestedInfo
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public string Name {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 1)]
       public string Phone {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 2)]
       public string Email {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 3)]
       public IPostAddress ShippingAddress {get; set;}

	}
}
