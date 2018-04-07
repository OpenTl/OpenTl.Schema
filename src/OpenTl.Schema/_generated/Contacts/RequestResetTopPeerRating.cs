// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1ae373ac)]
    public sealed class RequestResetTopPeerRating : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.ITopPeerCategory Category {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

    }
}
