// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInputStickerSetItem : IObject
    {
       BitArray Flags {get; set;}

       OpenTl.Schema.IInputDocument Document {get; set;}

       byte[] EmojiAsBinary {get; set;}
       string Emoji {get; set;}

       OpenTl.Schema.IMaskCoords MaskCoords {get; set;}

    }
}
