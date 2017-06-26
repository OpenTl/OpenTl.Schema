// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6319d612)]
	public class TDocumentAttributeSticker : IDocumentAttribute
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool Mask {get; set;}

       [SerializationOrder(2)]
       public string Alt {get; set;}

       [SerializationOrder(3)]
       public IInputStickerSet Stickerset {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 0)]
       public IMaskCoords MaskCoords {get; set;}

	}
}
