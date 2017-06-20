namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcc5b67cc)]
    public class RequestGetAttachedStickers : IRequest<TVector<IStickerSetCovered>>
    {
       [SerializationOrder(0)]
       public IInputStickeredMedia Media {get; set;}

    }
}
