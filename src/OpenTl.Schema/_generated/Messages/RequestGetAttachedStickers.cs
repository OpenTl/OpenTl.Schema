// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcc5b67cc)]
    public sealed class RequestGetAttachedStickers : IRequest<OpenTl.Schema.TVector<OpenTl.Schema.IStickerSetCovered>>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputStickeredMedia Media {get; set;}

    }
}
