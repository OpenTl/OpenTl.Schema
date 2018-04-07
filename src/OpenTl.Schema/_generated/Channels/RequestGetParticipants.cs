// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x123e05e9)]
    public sealed class RequestGetParticipants : IRequest<OpenTl.Schema.Channels.IChannelParticipants>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputChannel Channel {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IChannelParticipantsFilter Filter {get; set;}

       [SerializationOrder(2)]
       public int Offset {get; set;}

       [SerializationOrder(3)]
       public int Limit {get; set;}

       [SerializationOrder(4)]
       public int Hash {get; set;}

    }
}
