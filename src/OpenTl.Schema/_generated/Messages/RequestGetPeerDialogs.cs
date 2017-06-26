// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2d9776b9)]
    public class RequestGetPeerDialogs : IRequest<Messages.IPeerDialogs>
    {
       [SerializationOrder(0)]
       public TVector<IInputPeer> Peers {get; set;}

    }
}
