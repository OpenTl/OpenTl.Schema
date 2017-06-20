namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc78fe460)]
    public class RequestInstallStickerSet : IRequest<Messages.IStickerSetInstallResult>
    {
       [SerializationOrder(0)]
       public IInputStickerSet Stickerset {get; set;}

       [SerializationOrder(1)]
       public bool Archived {get; set;}

    }
}
