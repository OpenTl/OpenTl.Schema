// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe470bcfd)]
    public sealed class RequestGetPeerDialogs : IRequest<OpenTl.Schema.Messages.IPeerDialogs>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputDialogPeer> Peers {get; set;}

    }
}
