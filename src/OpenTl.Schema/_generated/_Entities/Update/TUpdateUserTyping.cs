// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5c486927)]
	public class TUpdateUserTyping : IUpdate
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

       [SerializationOrder(1)]
       public ISendMessageAction Action {get; set;}

	}
}
