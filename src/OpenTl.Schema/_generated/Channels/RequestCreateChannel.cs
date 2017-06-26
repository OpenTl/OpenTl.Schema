// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf4893d7f)]
    public class RequestCreateChannel : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Broadcast {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Megagroup {get; set;}

       [SerializationOrder(3)]
       public string Title {get; set;}

       [SerializationOrder(4)]
       public string About {get; set;}

    }
}
