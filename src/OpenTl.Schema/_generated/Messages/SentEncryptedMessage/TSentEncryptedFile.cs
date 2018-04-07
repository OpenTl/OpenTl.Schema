// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9493ff32)]
	public sealed class TSentEncryptedFile : ISentEncryptedMessage
	{
       [SerializationOrder(0)]
       public int Date {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IEncryptedFile File {get; set;}

	}
}
