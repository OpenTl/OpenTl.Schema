// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x546dd7a6)]
    public class RequestGetParticipant : IRequest<Channels.IChannelParticipant>
    {
       [SerializationOrder(0)]
       public IInputChannel Channel {get; set;}

       [SerializationOrder(1)]
       public IInputUser UserId {get; set;}

    }
}
