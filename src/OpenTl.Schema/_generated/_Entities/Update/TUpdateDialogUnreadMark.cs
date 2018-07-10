// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe16459c3)]
	public sealed class TUpdateDialogUnreadMark : IUpdate
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Unread {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IDialogPeer Peer {get; set;}

	}
}
