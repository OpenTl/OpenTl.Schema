// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe5f672fa)]
    public class RequestSetBotShippingResults : IRequest<bool>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public long QueryId {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public string Error {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public TVector<IShippingOption> ShippingOptions {get; set;}

    }
}
