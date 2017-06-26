// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8ef8ecc0)]
    public class RequestSetGameScore : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool EditMessage {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Force {get; set;}

       [SerializationOrder(3)]
       public IInputPeer Peer {get; set;}

       [SerializationOrder(4)]
       public int Id {get; set;}

       [SerializationOrder(5)]
       public IInputUser UserId {get; set;}

       [SerializationOrder(6)]
       public int Score {get; set;}

    }
}
