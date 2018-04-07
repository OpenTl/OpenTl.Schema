// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x74535f21)]
	public sealed class TMessagesNotModified : IMessages
	{
       [SerializationOrder(0)]
       public int Count {get; set;}

	}
}
