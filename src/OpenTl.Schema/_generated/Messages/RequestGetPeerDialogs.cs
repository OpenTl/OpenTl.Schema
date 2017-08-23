// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2d9776b9)]
    public class RequestGetPeerDialogs : IRequest<OpenTl.Schema.Messages.IPeerDialogs>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputPeer> Peers {get; set;}

    }
}
