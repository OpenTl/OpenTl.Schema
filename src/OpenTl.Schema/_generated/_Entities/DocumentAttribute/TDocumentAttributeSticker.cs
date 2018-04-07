// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6319d612)]
	public sealed class TDocumentAttributeSticker : IDocumentAttribute
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool Mask {get; set;}

       /// <summary>Binary representation for the 'Alt' property</summary>
       [SerializationOrder(2)]
       public byte[] AltAsBinary { get => _AltAsBinary; set { _Alt = Encoding.UTF8.GetString(value); _AltAsBinary = value; }}
       private byte[] _AltAsBinary;
       private string _Alt;
       public string Alt { get => _Alt; set { AltAsBinary = Encoding.UTF8.GetBytes(value); _Alt = value; }}

       [SerializationOrder(3)]
       public OpenTl.Schema.IInputStickerSet Stickerset {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.IMaskCoords MaskCoords {get; set;}

	}
}
