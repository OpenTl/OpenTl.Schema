// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x33963bf9)]
    public class RequestForwardMessage : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public IInputPeer Peer {get; set;}

       [SerializationOrder(1)]
       public int Id {get; set;}

       [SerializationOrder(2)]
       public long RandomId {get; set;}

    }
}
