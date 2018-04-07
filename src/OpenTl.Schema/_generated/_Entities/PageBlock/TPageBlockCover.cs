// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x39f23300)]
	public sealed class TPageBlockCover : IPageBlock
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IPageBlock Cover {get; set;}

	}
}
