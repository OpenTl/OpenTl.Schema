// ReSharper disable All

namespace OpenTl.Schema.Stickers
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4ed705ca)]
    public class RequestChangeStickerPosition : IRequest<bool>
    {
       [SerializationOrder(0)]
       public IInputDocument Sticker {get; set;}

       [SerializationOrder(1)]
       public int Position {get; set;}

    }
}
