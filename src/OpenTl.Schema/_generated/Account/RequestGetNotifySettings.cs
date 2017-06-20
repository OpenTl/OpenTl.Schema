namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x12b3ad31)]
    public class RequestGetNotifySettings : IRequest<IPeerNotifySettings>
    {
       [SerializationOrder(0)]
       public IInputNotifyPeer Peer {get; set;}

    }
}
