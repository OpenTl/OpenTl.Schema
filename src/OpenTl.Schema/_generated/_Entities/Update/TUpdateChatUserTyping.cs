// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9a65ea1f)]
	public class TUpdateChatUserTyping : IUpdate
	{
       [SerializationOrder(0)]
       public int ChatId {get; set;}

       [SerializationOrder(1)]
       public int UserId {get; set;}

       [SerializationOrder(2)]
       public ISendMessageAction Action {get; set;}

	}
}
