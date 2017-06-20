namespace OpenTl.Schema.Payments
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd1451883)]
	public class TValidatedRequestedInfo : IValidatedRequestedInfo
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public string Id {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 1)]
       public TVector<IShippingOption> ShippingOptions {get; set;}

	}
}
