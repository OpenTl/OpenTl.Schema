namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3672e09c)]
    public class RequestGetPeerSettings : IRequest<IPeerSettings>
    {
       [SerializationOrder(0)]
       public IInputPeer Peer {get; set;}

    }
}
