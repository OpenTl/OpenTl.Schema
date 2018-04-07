// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3a58c7f4)]
	public sealed class TPageBlockList : IPageBlock
	{
       [SerializationOrder(0)]
       public bool Ordered {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IRichText> Items {get; set;}

	}
}
