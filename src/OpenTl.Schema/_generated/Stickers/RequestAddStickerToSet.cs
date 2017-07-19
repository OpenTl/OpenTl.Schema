// ReSharper disable All

namespace OpenTl.Schema.Stickers
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8653febe)]
    public class RequestAddStickerToSet : IRequest<Messages.IStickerSet>
    {
       [SerializationOrder(0)]
       public IInputStickerSet Stickerset {get; set;}

       [SerializationOrder(1)]
       public IInputStickerSetItem Sticker {get; set;}

    }
}
