// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x292c7be9)]
	public class TPageBlockEmbedPost : IPageBlock
	{
       [SerializationOrder(0)]
       public string Url {get; set;}

       [SerializationOrder(1)]
       public long WebpageId {get; set;}

       [SerializationOrder(2)]
       public long AuthorPhotoId {get; set;}

       [SerializationOrder(3)]
       public string Author {get; set;}

       [SerializationOrder(4)]
       public int Date {get; set;}

       [SerializationOrder(5)]
       public TVector<IPageBlock> Blocks {get; set;}

       [SerializationOrder(6)]
       public IRichText Caption {get; set;}

	}
}
