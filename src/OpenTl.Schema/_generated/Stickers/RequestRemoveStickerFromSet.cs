// ReSharper disable All

namespace OpenTl.Schema.Stickers
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4255934)]
    public class RequestRemoveStickerFromSet : IRequest<bool>
    {
       [SerializationOrder(0)]
       public IInputDocument Sticker {get; set;}

    }
}
