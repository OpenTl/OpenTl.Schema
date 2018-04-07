// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x13d6dd27)]
	public sealed class TEncryptedChatDiscarded : IEncryptedChat
	{
       [SerializationOrder(0)]
       public int Id {get; set;}

	}
}
