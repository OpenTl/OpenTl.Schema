// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbaafe5e0)]
	public sealed class TPageBlockAuthorDate : IPageBlock
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IRichText Author {get; set;}

       [SerializationOrder(1)]
       public int PublishedDate {get; set;}

	}
}
