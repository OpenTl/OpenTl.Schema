namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc30aa358)]
	public class TInvoice : IInvoice
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Test {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool NameRequested {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 2)]
       public bool PhoneRequested {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 3)]
       public bool EmailRequested {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 4)]
       public bool ShippingAddressRequested {get; set;}

       [SerializationOrder(6)]
       [FromFlag("Flags", 5)]
       public bool Flexible {get; set;}

       [SerializationOrder(7)]
       public string Currency {get; set;}

       [SerializationOrder(8)]
       public TVector<ILabeledPrice> Prices {get; set;}

	}
}
