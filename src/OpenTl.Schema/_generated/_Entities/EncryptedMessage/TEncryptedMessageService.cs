// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x23734b06)]
	public sealed class TEncryptedMessageService : IEncryptedMessage
	{
       [SerializationOrder(0)]
       public long RandomId {get; set;}

       [SerializationOrder(1)]
       public int ChatId {get; set;}

       [SerializationOrder(2)]
       public int Date {get; set;}

       [SerializationOrder(3)]
       public byte[] Bytes {get; set;}

	}
}
