// ReSharper disable All

namespace OpenTl.Schema.Payments
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4e5f810d)]
	public class TPaymentResult : IPaymentResult
	{
       [SerializationOrder(0)]
       public IUpdates Updates {get; set;}

	}
}
