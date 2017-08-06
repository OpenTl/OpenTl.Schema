// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3407e51b)]
	public class TStickerSetMultiCovered : IStickerSetCovered
	{
       [SerializationOrder(0)]
       public IStickerSet Set {get; set;}

       [SerializationOrder(1)]
       public TVector<IDocument> Covers {get; set;}

	}
}
