// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x57f17692)]
    public sealed class RequestGetArchivedStickers : IRequest<OpenTl.Schema.Messages.IArchivedStickers>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Masks {get; set;}

       [SerializationOrder(2)]
       public long OffsetId {get; set;}

       [SerializationOrder(3)]
       public int Limit {get; set;}

    }
}
