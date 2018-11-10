// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[System.Serializable]
	[Serialize(0xab7ec0a0)]
	public sealed class TEncryptedChatEmpty : IEncryptedChat, IEmpty
	{
       [SerializationOrder(0)]
       public int Id {get; set;}

	}
}
