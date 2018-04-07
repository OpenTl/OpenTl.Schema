// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3407e51b)]
	public sealed class TStickerSetMultiCovered : IStickerSetCovered
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IStickerSet Set {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IDocument> Covers {get; set;}

	}
}
