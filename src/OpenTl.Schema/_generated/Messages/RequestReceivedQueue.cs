// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x55a5bb66)]
    public sealed class RequestReceivedQueue : IRequest<OpenTl.Schema.TVector<long>>
    {
       [SerializationOrder(0)]
       public int MaxQts {get; set;}

    }
}
