namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6410a5d2)]
	public class TStickerSetCovered : IStickerSetCovered
	{
       [SerializationOrder(0)]
       public IStickerSet Set {get; set;}

       [SerializationOrder(1)]
       public IDocument Cover {get; set;}

	}
}
