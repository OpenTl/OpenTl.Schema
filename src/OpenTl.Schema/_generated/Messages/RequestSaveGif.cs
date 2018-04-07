// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x327a30cb)]
    public sealed class RequestSaveGif : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputDocument Id {get; set;}

       [SerializationOrder(1)]
       public bool Unsave {get; set;}

    }
}
