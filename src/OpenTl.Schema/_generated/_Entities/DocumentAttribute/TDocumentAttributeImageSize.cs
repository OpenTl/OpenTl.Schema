// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6c37c15c)]
	public sealed class TDocumentAttributeImageSize : IDocumentAttribute
	{
       [SerializationOrder(0)]
       public int W {get; set;}

       [SerializationOrder(1)]
       public int H {get; set;}

	}
}
