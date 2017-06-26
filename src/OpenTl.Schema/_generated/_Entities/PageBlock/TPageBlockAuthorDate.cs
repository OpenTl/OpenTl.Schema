// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbaafe5e0)]
	public class TPageBlockAuthorDate : IPageBlock
	{
       [SerializationOrder(0)]
       public IRichText Author {get; set;}

       [SerializationOrder(1)]
       public int PublishedDate {get; set;}

	}
}
