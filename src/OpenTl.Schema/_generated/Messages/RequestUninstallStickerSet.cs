// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf96e55de)]
    public sealed class RequestUninstallStickerSet : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputStickerSet Stickerset {get; set;}

    }
}
