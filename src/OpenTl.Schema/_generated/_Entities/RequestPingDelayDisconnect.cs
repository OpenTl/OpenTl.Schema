namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf3427b8c)]
    public class RequestPingDelayDisconnect : IRequest<IPong>
    {
       [SerializationOrder(0)]
       public long PingId {get; set;}

       [SerializationOrder(1)]
       public int DisconnectDelay {get; set;}

    }
}
