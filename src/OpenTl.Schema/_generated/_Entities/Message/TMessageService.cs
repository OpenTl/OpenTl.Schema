// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9e19a1f6)]
	public sealed class TMessageService : IMessage
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool Out {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 4)]
       public bool Mentioned {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 5)]
       public bool MediaUnread {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 13)]
       public bool Silent {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 14)]
       public bool Post {get; set;}

       [SerializationOrder(6)]
       public int Id {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 8)]
       public int FromId {get; set;}

       [SerializationOrder(8)]
       public OpenTl.Schema.IPeer ToId {get; set;}

       [SerializationOrder(9)]
       [CanSerialize("Flags", 3)]
       public int ReplyToMsgId {get; set;}

       [SerializationOrder(10)]
       public int Date {get; set;}

       [SerializationOrder(11)]
       public OpenTl.Schema.IMessageAction Action {get; set;}

	}
}
