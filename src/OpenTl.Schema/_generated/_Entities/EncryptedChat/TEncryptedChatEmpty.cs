// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xab7ec0a0)]
	public class TEncryptedChatEmpty : IEncryptedChat, IEmpty
	{
       [SerializationOrder(0)]
       public int Id {get; set;}

	}
}
