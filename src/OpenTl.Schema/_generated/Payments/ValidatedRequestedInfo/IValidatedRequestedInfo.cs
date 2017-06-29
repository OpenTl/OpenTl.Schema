// ReSharper disable All

namespace OpenTl.Schema.Payments
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IValidatedRequestedInfo : IObject
    {
        BitArray Flags {get; set;}

        string Id {get; set;}

        TVector<IShippingOption> ShippingOptions {get; set;}

    }
}
