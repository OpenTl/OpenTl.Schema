// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8736a09)]
    public class RequestGetFullChannel : IRequest<Messages.IChatFull>
    {
       [SerializationOrder(0)]
       public IInputChannel Channel {get; set;}

    }
}
