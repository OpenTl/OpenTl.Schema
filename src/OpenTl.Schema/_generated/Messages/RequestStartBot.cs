// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe6df7378)]
    public class RequestStartBot : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public IInputUser Bot {get; set;}

       [SerializationOrder(1)]
       public IInputPeer Peer {get; set;}

       [SerializationOrder(2)]
       public long RandomId {get; set;}

       [SerializationOrder(3)]
       public string StartParam {get; set;}

    }
}
