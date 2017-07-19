// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xffa0a496)]
	public class TInputStickerSetItem : IInputStickerSetItem
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public IInputDocument Document {get; set;}

       [SerializationOrder(2)]
       public string Emoji {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public IMaskCoords MaskCoords {get; set;}

	}
}
