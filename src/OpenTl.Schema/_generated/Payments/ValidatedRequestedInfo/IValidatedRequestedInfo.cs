// ReSharper disable All

namespace OpenTl.Schema.Payments
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IValidatedRequestedInfo : IObject
    {
       BitArray Flags {get; set;}

       byte[] IdAsBinary {get; set;}
       string Id {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IShippingOption> ShippingOptions {get; set;}

    }
}
