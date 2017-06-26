// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd7a19d69)]
	public class TPageFull : IPage
	{
       [SerializationOrder(0)]
       public TVector<IPageBlock> Blocks {get; set;}

       [SerializationOrder(1)]
       public TVector<IPhoto> Photos {get; set;}

       [SerializationOrder(2)]
       public TVector<IDocument> Videos {get; set;}

	}
}
