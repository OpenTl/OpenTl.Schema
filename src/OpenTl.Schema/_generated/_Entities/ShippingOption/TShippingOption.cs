// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb6213cdf)]
	public class TShippingOption : IShippingOption
	{
       [SerializationOrder(0)]
       public string Id {get; set;}

       [SerializationOrder(1)]
       public string Title {get; set;}

       [SerializationOrder(2)]
       public TVector<ILabeledPrice> Prices {get; set;}

	}
}
