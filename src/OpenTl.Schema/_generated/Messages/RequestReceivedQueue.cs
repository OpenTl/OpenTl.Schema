// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x55a5bb66)]
    public class RequestReceivedQueue : IRequest<TVector<long>>
    {
       [SerializationOrder(0)]
       public int MaxQts {get; set;}

    }
}
