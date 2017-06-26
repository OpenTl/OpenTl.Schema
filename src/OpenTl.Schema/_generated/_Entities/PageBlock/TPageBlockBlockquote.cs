// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x263d7c26)]
	public class TPageBlockBlockquote : IPageBlock
	{
       [SerializationOrder(0)]
       public IRichText Ext {get; set;}

       [SerializationOrder(1)]
       public IRichText Caption {get; set;}

	}
}
