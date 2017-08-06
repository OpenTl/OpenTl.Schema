// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5a954c0)]
    public class RequestReceivedMessages : IRequest<TVector<TReceivedNotifyMessage>>
    {
       [SerializationOrder(0)]
       public int MaxId {get; set;}

    }
}
