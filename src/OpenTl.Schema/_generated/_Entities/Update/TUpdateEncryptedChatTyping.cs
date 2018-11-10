// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[System.Serializable]
	[Serialize(0x1710f156)]
	public sealed class TUpdateEncryptedChatTyping : IUpdate
	{
       [SerializationOrder(0)]
       public int ChatId {get; set;}

	}
}
