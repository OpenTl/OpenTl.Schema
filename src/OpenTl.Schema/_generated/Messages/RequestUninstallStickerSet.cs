namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf96e55de)]
    public class RequestUninstallStickerSet : IRequest<bool>
    {
       [SerializationOrder(0)]
       public IInputStickerSet Stickerset {get; set;}

    }
}
