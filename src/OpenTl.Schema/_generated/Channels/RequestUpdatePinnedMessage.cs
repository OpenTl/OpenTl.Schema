// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa72ded52)]
    public sealed class RequestUpdatePinnedMessage : IRequest<OpenTl.Schema.IUpdates>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Silent {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IInputChannel Channel {get; set;}

       [SerializationOrder(3)]
       public int Id {get; set;}

    }
}
