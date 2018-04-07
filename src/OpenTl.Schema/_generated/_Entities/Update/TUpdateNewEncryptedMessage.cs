// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x12bcbd9a)]
	public sealed class TUpdateNewEncryptedMessage : IUpdate
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IEncryptedMessage Message {get; set;}

       [SerializationOrder(1)]
       public int Qts {get; set;}

	}
}
