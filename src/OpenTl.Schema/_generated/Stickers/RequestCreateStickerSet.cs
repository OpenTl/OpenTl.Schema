// ReSharper disable All

namespace OpenTl.Schema.Stickers
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9bd86e6a)]
    public class RequestCreateStickerSet : IRequest<Messages.IStickerSet>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Masks {get; set;}

       [SerializationOrder(2)]
       public IInputUser UserId {get; set;}

       [SerializationOrder(3)]
       public string Title {get; set;}

       [SerializationOrder(4)]
       public string ShortName {get; set;}

       [SerializationOrder(5)]
       public TVector<IInputStickerSetItem> Stickers {get; set;}

    }
}
