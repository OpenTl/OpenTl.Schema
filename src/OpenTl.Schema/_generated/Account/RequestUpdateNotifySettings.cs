namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x84be5b93)]
    public class RequestUpdateNotifySettings : IRequest<bool>
    {
       [SerializationOrder(0)]
       public IInputNotifyPeer Peer {get; set;}

       [SerializationOrder(1)]
       public IInputPeerNotifySettings Settings {get; set;}

    }
}
