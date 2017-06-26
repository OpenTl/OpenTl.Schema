// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcde200d1)]
	public class TPageBlockEmbed : IPageBlock
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool FullWidth {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 3)]
       public bool AllowScrolling {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public string Url {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 2)]
       public string Html {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 4)]
       public long PosterPhotoId {get; set;}

       [SerializationOrder(6)]
       public int W {get; set;}

       [SerializationOrder(7)]
       public int H {get; set;}

       [SerializationOrder(8)]
       public IRichText Caption {get; set;}

	}
}
