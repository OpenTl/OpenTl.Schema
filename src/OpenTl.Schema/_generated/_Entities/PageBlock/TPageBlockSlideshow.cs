namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x130c8963)]
	public class TPageBlockSlideshow : IPageBlock
	{
       [SerializationOrder(0)]
       public TVector<IPageBlock> Items {get; set;}

       [SerializationOrder(1)]
       public IRichText Caption {get; set;}

	}
}
