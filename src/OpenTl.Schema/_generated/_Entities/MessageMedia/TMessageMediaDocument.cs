// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7c4414d3)]
	public class TMessageMediaDocument : IMessageMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public IDocument Document {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 1)]
       public string Caption {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 2)]
       public int TtlSeconds {get; set;}

	}
}
