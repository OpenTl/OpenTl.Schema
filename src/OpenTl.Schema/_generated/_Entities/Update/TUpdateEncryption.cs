// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb4a2e88d)]
	public class TUpdateEncryption : IUpdate
	{
       [SerializationOrder(0)]
       public IEncryptedChat Chat {get; set;}

       [SerializationOrder(1)]
       public int Date {get; set;}

	}
}
