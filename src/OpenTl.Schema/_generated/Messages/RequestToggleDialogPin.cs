// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3289be6a)]
    public class RequestToggleDialogPin : IRequest<bool>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Pinned {get; set;}

       [SerializationOrder(2)]
       public IInputPeer Peer {get; set;}

    }
}
