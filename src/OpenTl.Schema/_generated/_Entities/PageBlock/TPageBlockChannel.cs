// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xef1751b5)]
	public class TPageBlockChannel : IPageBlock
	{
       [SerializationOrder(0)]
       public IChat Channel {get; set;}

	}
}
