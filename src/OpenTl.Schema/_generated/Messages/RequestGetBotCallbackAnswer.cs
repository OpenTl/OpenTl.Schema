namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x810a9fec)]
    public class RequestGetBotCallbackAnswer : IRequest<Messages.IBotCallbackAnswer>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool Game {get; set;}

       [SerializationOrder(2)]
       public IInputPeer Peer {get; set;}

       [SerializationOrder(3)]
       public int MsgId {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 0)]
       public byte[] Data {get; set;}

    }
}
