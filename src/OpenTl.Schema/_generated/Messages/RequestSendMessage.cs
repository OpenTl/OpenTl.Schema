// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xfa88427a)]
    public sealed class RequestSendMessage : IRequest<OpenTl.Schema.IUpdates>
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
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 0)]
       public int ReplyToMsgId {get; set;}

       /// <summary>Binary representation for the 'Message' property</summary>
       [SerializationOrder(7)]
       public byte[] MessageAsBinary { get => _MessageAsBinary; set { _Message = Encoding.UTF8.GetString(value); _MessageAsBinary = value; }}
       private byte[] _MessageAsBinary;
       private string _Message;
       public string Message { get => _Message; set { MessageAsBinary = Encoding.UTF8.GetBytes(value); _Message = value; }}

       [SerializationOrder(8)]
       public long RandomId {get; set;}

       [SerializationOrder(9)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IReplyMarkup ReplyMarkup {get; set;}

       [SerializationOrder(10)]
       [CanSerialize("Flags", 3)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IMessageEntity> Entities {get; set;}

    }
}
