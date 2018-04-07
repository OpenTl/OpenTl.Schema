// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7abe77ec)]
    public sealed class RequestPing : IRequest<OpenTl.Schema.IPong>
    {
       [SerializationOrder(0)]
       public long PingId {get; set;}

    }
}
