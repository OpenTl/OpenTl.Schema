namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xfa88427a)]
    public class RequestSendMessage : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool NoWebpage {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 5)]
       public bool Silent {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 6)]
       public bool Background {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 7)]
       public bool ClearDraft {get; set;}

       [SerializationOrder(5)]
       public IInputPeer Peer {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 0)]
       public int ReplyToMsgId {get; set;}

       [SerializationOrder(7)]
       public string Message {get; set;}

       [SerializationOrder(8)]
       public long RandomId {get; set;}

       [SerializationOrder(9)]
       [CanSerialize("Flags", 2)]
       public IReplyMarkup ReplyMarkup {get; set;}

       [SerializationOrder(10)]
       [CanSerialize("Flags", 3)]
       public TVector<IMessageEntity> Entities {get; set;}

    }
}
