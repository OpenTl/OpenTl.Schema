// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5b118126)]
    public sealed class RequestReadFeaturedStickers : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<long> Id {get; set;}

    }
}
