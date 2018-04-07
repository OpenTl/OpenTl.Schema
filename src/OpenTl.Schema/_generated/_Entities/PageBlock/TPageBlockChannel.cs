// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xef1751b5)]
	public sealed class TPageBlockChannel : IPageBlock
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IChat Channel {get; set;}

	}
}
