// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x560f8935)]
	public sealed class TSentEncryptedMessage : ISentEncryptedMessage
	{
       [SerializationOrder(0)]
       public int Date {get; set;}

	}
}
