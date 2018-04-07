// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xffa0a496)]
	public sealed class TInputStickerSetItem : IInputStickerSetItem
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputDocument Document {get; set;}

       /// <summary>Binary representation for the 'Emoji' property</summary>
       [SerializationOrder(2)]
       public byte[] EmojiAsBinary { get => _EmojiAsBinary; set { _Emoji = Encoding.UTF8.GetString(value); _EmojiAsBinary = value; }}
       private byte[] _EmojiAsBinary;
       private string _Emoji;
       public string Emoji { get => _Emoji; set { EmojiAsBinary = Encoding.UTF8.GetBytes(value); _Emoji = value; }}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.IMaskCoords MaskCoords {get; set;}

	}
}
