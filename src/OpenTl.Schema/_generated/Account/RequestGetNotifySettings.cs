// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x12b3ad31)]
    public class RequestGetNotifySettings : IRequest<OpenTl.Schema.IPeerNotifySettings>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputNotifyPeer Peer {get; set;}

    }
}
