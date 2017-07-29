// ReSharper disable All

namespace OpenTl.Schema.Stickers
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf7760f51)]
    public class RequestRemoveStickerFromSet : IRequest<Messages.IStickerSet>
    {
       [SerializationOrder(0)]
       public IInputDocument Sticker {get; set;}

    }
}
