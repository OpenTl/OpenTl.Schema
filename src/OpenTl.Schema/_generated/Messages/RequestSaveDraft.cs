// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbc39e14b)]
    public class RequestSaveDraft : IRequest<bool>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool NoWebpage {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public int ReplyToMsgId {get; set;}

       [SerializationOrder(3)]
       public IInputPeer Peer {get; set;}

       [SerializationOrder(4)]
       public string Message {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 3)]
       public TVector<IMessageEntity> Entities {get; set;}

    }
}
