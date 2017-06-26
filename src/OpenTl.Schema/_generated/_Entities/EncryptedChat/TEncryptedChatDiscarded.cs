// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x13d6dd27)]
	public class TEncryptedChatDiscarded : IEncryptedChat
	{
       [SerializationOrder(0)]
       public int Id {get; set;}

	}
}
