// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb9ffc55b)]
    public sealed class RequestFaveSticker : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputDocument Id {get; set;}

       [SerializationOrder(1)]
       public bool Unfave {get; set;}

    }
}
