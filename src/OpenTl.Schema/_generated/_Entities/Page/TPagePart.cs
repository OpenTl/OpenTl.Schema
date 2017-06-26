// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8dee6c44)]
	public class TPagePart : IPage
	{
       [SerializationOrder(0)]
       public TVector<IPageBlock> Blocks {get; set;}

       [SerializationOrder(1)]
       public TVector<IPhoto> Photos {get; set;}

       [SerializationOrder(2)]
       public TVector<IDocument> Videos {get; set;}

	}
}
