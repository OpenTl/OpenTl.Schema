namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x24d98f92)]
    public class RequestGetParticipants : IRequest<Channels.IChannelParticipants>
    {
       [SerializationOrder(0)]
       public IInputChannel Channel {get; set;}

       [SerializationOrder(1)]
       public IChannelParticipantsFilter Filter {get; set;}

       [SerializationOrder(2)]
       public int Offset {get; set;}

       [SerializationOrder(3)]
       public int Limit {get; set;}

    }
}
