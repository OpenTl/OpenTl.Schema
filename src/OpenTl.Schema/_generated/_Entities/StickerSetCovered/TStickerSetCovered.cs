// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6410a5d2)]
	public sealed class TStickerSetCovered : IStickerSetCovered
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IStickerSet Set {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IDocument Cover {get; set;}

	}
}
