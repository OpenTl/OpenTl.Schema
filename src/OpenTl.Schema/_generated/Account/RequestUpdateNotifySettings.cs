// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x84be5b93)]
    public sealed class RequestUpdateNotifySettings : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputNotifyPeer Peer {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputPeerNotifySettings Settings {get; set;}

    }
}
