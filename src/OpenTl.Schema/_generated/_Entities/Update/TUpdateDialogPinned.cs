// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x19d27f3c)]
	public sealed class TUpdateDialogPinned : IUpdate
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Pinned {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IDialogPeer Peer {get; set;}

	}
}
