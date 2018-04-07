// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf3427b8c)]
    public sealed class RequestPingDelayDisconnect : IRequest<OpenTl.Schema.IPong>
    {
       [SerializationOrder(0)]
       public long PingId {get; set;}

       [SerializationOrder(1)]
       public int DisconnectDelay {get; set;}

    }
}
