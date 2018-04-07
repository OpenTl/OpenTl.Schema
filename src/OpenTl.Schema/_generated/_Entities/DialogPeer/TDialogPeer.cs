// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe56dbf05)]
	public sealed class TDialogPeer : IDialogPeer
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IPeer Peer {get; set;}

	}
}
