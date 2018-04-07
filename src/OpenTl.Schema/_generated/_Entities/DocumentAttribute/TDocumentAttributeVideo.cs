// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xef02ce6)]
	public sealed class TDocumentAttributeVideo : IDocumentAttribute
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool RoundMessage {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool SupportsStreaming {get; set;}

       [SerializationOrder(3)]
       public int Duration {get; set;}

       [SerializationOrder(4)]
       public int W {get; set;}

       [SerializationOrder(5)]
       public int H {get; set;}

	}
}
