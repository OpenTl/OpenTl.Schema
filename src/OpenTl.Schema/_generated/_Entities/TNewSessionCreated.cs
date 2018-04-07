// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9ec20908)]
	public sealed class TNewSessionCreated : IObject
	{
       [SerializationOrder(0)]
       public long FirstMsgId {get; set;}

       [SerializationOrder(1)]
       public long UniqueId {get; set;}

       [SerializationOrder(2)]
       public long ServerSalt {get; set;}

	}
}
