// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IShippingOption : IObject
    {
        string Id {get; set;}

        string Title {get; set;}

        TVector<ILabeledPrice> Prices {get; set;}

    }
}
