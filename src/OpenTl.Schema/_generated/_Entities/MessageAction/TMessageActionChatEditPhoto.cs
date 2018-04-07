// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7fcb13a8)]
	public sealed class TMessageActionChatEditPhoto : IMessageAction
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IPhoto Photo {get; set;}

	}
}
