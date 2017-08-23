// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x24d98f92)]
    public class RequestGetParticipants : IRequest<OpenTl.Schema.Channels.IChannelParticipants>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputChannel Channel {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IChannelParticipantsFilter Filter {get; set;}

       [SerializationOrder(2)]
       public int Offset {get; set;}

       [SerializationOrder(3)]
       public int Limit {get; set;}

    }
}
