// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd9d71866)]
	public sealed class TPageBlockVideo : IPageBlock
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Autoplay {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Loop {get; set;}

       [SerializationOrder(3)]
       public long VideoId {get; set;}

       [SerializationOrder(4)]
       public OpenTl.Schema.IRichText Caption {get; set;}

	}
}
