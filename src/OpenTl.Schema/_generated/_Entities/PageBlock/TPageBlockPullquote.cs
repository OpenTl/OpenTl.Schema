// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4f4456d3)]
	public sealed class TPageBlockPullquote : IPageBlock
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IRichText Text {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IRichText Caption {get; set;}

	}
}
