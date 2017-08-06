// ReSharper disable All

namespace OpenTl.Schema.Stickers
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xffb6d4ca)]
    public class RequestChangeStickerPosition : IRequest<Messages.IStickerSet>
    {
       [SerializationOrder(0)]
       public IInputDocument Sticker {get; set;}

       [SerializationOrder(1)]
       public int Position {get; set;}

    }
}
