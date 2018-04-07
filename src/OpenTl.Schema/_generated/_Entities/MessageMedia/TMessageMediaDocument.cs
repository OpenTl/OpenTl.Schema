// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9cb070d7)]
	public sealed class TMessageMediaDocument : IMessageMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.IDocument Document {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 2)]
       public int TtlSeconds {get; set;}

	}
}
