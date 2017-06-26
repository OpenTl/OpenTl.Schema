// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1c015b09)]
    public class RequestDeleteHistory : IRequest<Messages.IAffectedHistory>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool JustClear {get; set;}

       [SerializationOrder(2)]
       public IInputPeer Peer {get; set;}

       [SerializationOrder(3)]
       public int MaxId {get; set;}

    }
}
