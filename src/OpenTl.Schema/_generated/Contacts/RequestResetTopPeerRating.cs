// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1ae373ac)]
    public class RequestResetTopPeerRating : IRequest<bool>
    {
       [SerializationOrder(0)]
       public ITopPeerCategory Category {get; set;}

       [SerializationOrder(1)]
       public IInputPeer Peer {get; set;}

    }
}
