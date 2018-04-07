// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x695150d7)]
	public sealed class TMessageMediaPhoto : IMessageMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.IPhoto Photo {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 2)]
       public int TtlSeconds {get; set;}

	}
}
