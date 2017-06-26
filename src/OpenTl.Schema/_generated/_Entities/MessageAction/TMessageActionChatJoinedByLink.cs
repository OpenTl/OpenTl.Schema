// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf89cf5e8)]
	public class TMessageActionChatJoinedByLink : IMessageAction
	{
       [SerializationOrder(0)]
       public int InviterId {get; set;}

	}
}
