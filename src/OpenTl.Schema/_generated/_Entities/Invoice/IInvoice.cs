// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInvoice : IObject
    {
       BitArray Flags {get; set;}

       bool Test {get; set;}

       bool NameRequested {get; set;}

       bool PhoneRequested {get; set;}

       bool EmailRequested {get; set;}

       bool ShippingAddressRequested {get; set;}

       bool Flexible {get; set;}

       bool PhoneToProvider {get; set;}

       bool EmailToProvider {get; set;}

       byte[] CurrencyAsBinary {get; set;}
       string Currency {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.ILabeledPrice> Prices {get; set;}

    }
}
