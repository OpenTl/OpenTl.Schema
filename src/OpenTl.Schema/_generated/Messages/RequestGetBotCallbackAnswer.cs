// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x810a9fec)]
    public sealed class RequestGetBotCallbackAnswer : IRequest<OpenTl.Schema.Messages.IBotCallbackAnswer>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool Game {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(3)]
       public int MsgId {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 0)]
       public byte[] Data {get; set;}

    }
}
