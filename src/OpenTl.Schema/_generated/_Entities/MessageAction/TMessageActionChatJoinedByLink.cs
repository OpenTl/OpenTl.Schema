// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf89cf5e8)]
	public sealed class TMessageActionChatJoinedByLink : IMessageAction
	{
       [SerializationOrder(0)]
       public int InviterId {get; set;}

	}
}
