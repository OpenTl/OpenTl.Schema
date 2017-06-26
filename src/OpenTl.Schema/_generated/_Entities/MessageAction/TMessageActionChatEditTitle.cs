// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb5a1ce5a)]
	public class TMessageActionChatEditTitle : IMessageAction
	{
       [SerializationOrder(0)]
       public string Itle {get; set;}

	}
}
