// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc78fe460)]
    public sealed class RequestInstallStickerSet : IRequest<OpenTl.Schema.Messages.IStickerSetInstallResult>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputStickerSet Stickerset {get; set;}

       [SerializationOrder(1)]
       public bool Archived {get; set;}

    }
}
