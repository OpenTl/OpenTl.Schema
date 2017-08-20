// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInputStickerSetItem : IObject
    {
       BitArray Flags {get; set;}

       IInputDocument Document {get; set;}

       byte[] EmojiAsBinary {get; set;}
       string Emoji {get; set;}

       IMaskCoords MaskCoords {get; set;}

    }
}
