// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x12bcbd9a)]
	public class TUpdateNewEncryptedMessage : IUpdate
	{
       [SerializationOrder(0)]
       public IEncryptedMessage Message {get; set;}

       [SerializationOrder(1)]
       public int Qts {get; set;}

	}
}
