// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc286d98f)]
    public sealed class RequestMarkDialogUnread : IRequest<bool>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Unread {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IInputDialogPeer Peer {get; set;}

    }
}
