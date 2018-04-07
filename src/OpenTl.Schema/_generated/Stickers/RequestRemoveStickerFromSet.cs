// ReSharper disable All

namespace OpenTl.Schema.Stickers
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf7760f51)]
    public sealed class RequestRemoveStickerFromSet : IRequest<OpenTl.Schema.Messages.IStickerSet>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputDocument Sticker {get; set;}

    }
}
