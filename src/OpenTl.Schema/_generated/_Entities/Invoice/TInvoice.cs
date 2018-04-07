// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc30aa358)]
	public sealed class TInvoice : IInvoice
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
       [FromFlag("Flags", 6)]
       public bool PhoneToProvider {get; set;}

       [SerializationOrder(8)]
       [FromFlag("Flags", 7)]
       public bool EmailToProvider {get; set;}

       /// <summary>Binary representation for the 'Currency' property</summary>
       [SerializationOrder(9)]
       public byte[] CurrencyAsBinary { get => _CurrencyAsBinary; set { _Currency = Encoding.UTF8.GetString(value); _CurrencyAsBinary = value; }}
       private byte[] _CurrencyAsBinary;
       private string _Currency;
       public string Currency { get => _Currency; set { CurrencyAsBinary = Encoding.UTF8.GetBytes(value); _Currency = value; }}

       [SerializationOrder(10)]
       public OpenTl.Schema.TVector<OpenTl.Schema.ILabeledPrice> Prices {get; set;}

	}
}
