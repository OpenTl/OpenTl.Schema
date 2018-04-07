// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x347773c5)]
	public sealed class TPong : IPong
	{
       [SerializationOrder(0)]
       public long MsgId {get; set;}

       [SerializationOrder(1)]
       public long PingId {get; set;}

	}
}
