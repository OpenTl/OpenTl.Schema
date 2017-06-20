namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2daf01a7)]
	public class TInputBotInlineMessageMediaContact : IInputBotInlineMessage
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public string PhoneNumber {get; set;}

       [SerializationOrder(2)]
       public string FirstName {get; set;}

       [SerializationOrder(3)]
       public string LastName {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 2)]
       public IReplyMarkup ReplyMarkup {get; set;}

	}
}
