// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IShippingOption : IObject
    {
       byte[] IdAsBinary {get; set;}
       string Id {get; set;}

       byte[] TitleAsBinary {get; set;}
       string Title {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.ILabeledPrice> Prices {get; set;}

    }
}
