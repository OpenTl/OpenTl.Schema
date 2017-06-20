namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7abe77ec)]
    public class RequestPing : IRequest<IPong>
    {
       [SerializationOrder(0)]
       public long PingId {get; set;}

    }
}
