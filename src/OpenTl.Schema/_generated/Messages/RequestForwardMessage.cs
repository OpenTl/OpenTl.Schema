// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x33963bf9)]
    public class RequestForwardMessage : IRequest<OpenTl.Schema.IUpdates>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(1)]
       public int Id {get; set;}

       [SerializationOrder(2)]
       public long RandomId {get; set;}

    }
}
