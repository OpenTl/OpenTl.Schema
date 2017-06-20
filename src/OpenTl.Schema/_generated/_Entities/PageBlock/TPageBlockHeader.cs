namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbfd064ec)]
	public class TPageBlockHeader : IPageBlock
	{
       [SerializationOrder(0)]
       public IRichText Ext {get; set;}

	}
}
