// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x392718f8)]
    public sealed class RequestSaveRecentSticker : IRequest<bool>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Attached {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IInputDocument Id {get; set;}

       [SerializationOrder(3)]
       public bool Unsave {get; set;}

    }
}
