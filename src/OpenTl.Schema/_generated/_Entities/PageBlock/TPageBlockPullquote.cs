namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4f4456d3)]
	public class TPageBlockPullquote : IPageBlock
	{
       [SerializationOrder(0)]
       public IRichText Ext {get; set;}

       [SerializationOrder(1)]
       public IRichText Caption {get; set;}

	}
}
