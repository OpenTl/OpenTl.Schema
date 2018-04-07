// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb2ae9b0c)]
	public sealed class TMessageActionChatDeleteUser : IMessageAction
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

	}
}
