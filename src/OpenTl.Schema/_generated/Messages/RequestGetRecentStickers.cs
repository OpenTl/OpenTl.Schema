// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5ea192c9)]
    public sealed class RequestGetRecentStickers : IRequest<OpenTl.Schema.Messages.IRecentStickers>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Attached {get; set;}

       [SerializationOrder(2)]
       public int Hash {get; set;}

    }
}
