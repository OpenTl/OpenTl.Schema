namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xce0d37b0)]
	public class TPageBlockAnchor : IPageBlock
	{
       [SerializationOrder(0)]
       public string Name {get; set;}

	}
}
