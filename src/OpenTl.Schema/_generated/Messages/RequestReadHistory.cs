// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe306d3a)]
    public class RequestReadHistory : IRequest<Messages.IAffectedMessages>
    {
       [SerializationOrder(0)]
       public IInputPeer Peer {get; set;}

       [SerializationOrder(1)]
       public int MaxId {get; set;}

    }
}
