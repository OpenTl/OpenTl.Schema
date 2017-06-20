namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8c7f65e2)]
	public class TBotInlineMessageText : IBotInlineMessage
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool NoWebpage {get; set;}

       [SerializationOrder(2)]
       public string Message {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public TVector<IMessageEntity> Entities {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 2)]
       public IReplyMarkup ReplyMarkup {get; set;}

	}
}
