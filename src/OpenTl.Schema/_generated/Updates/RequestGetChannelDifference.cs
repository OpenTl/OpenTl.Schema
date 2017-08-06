// ReSharper disable All

namespace OpenTl.Schema.Updates
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3173d78)]
    public class RequestGetChannelDifference : IRequest<Updates.IChannelDifference>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Force {get; set;}

       [SerializationOrder(2)]
       public IInputChannel Channel {get; set;}

       [SerializationOrder(3)]
       public IChannelMessagesFilter Filter {get; set;}

       [SerializationOrder(4)]
       public int Pts {get; set;}

       [SerializationOrder(5)]
       public int Limit {get; set;}

    }
}
