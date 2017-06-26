// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xef02ce6)]
	public class TDocumentAttributeVideo : IDocumentAttribute
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool RoundMessage {get; set;}

       [SerializationOrder(2)]
       public int Duration {get; set;}

       [SerializationOrder(3)]
       public int W {get; set;}

       [SerializationOrder(4)]
       public int H {get; set;}

	}
}
