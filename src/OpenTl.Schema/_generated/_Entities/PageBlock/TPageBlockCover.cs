namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x39f23300)]
	public class TPageBlockCover : IPageBlock
	{
       [SerializationOrder(0)]
       public IPageBlock Cover {get; set;}

	}
}
