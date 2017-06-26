// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc070d93e)]
	public class TPageBlockPreformatted : IPageBlock
	{
       [SerializationOrder(0)]
       public IRichText Ext {get; set;}

       [SerializationOrder(1)]
       public string Language {get; set;}

	}
}
