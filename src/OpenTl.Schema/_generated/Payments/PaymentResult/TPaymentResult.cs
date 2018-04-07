// ReSharper disable All

namespace OpenTl.Schema.Payments
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4e5f810d)]
	public sealed class TPaymentResult : IPaymentResult
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IUpdates Updates {get; set;}

	}
}
