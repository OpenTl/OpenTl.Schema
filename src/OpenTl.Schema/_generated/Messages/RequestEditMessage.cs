// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xce91e4ca)]
    public class RequestEditMessage : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool NoWebpage {get; set;}

       [SerializationOrder(2)]
       public IInputPeer Peer {get; set;}

       [SerializationOrder(3)]
       public int Id {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 11)]
       public string Message {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 2)]
       public IReplyMarkup ReplyMarkup {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 3)]
       public TVector<IMessageEntity> Entities {get; set;}

    }
}
