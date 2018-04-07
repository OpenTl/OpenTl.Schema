// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9fd40bd8)]
	public sealed class TNotifyPeer : INotifyPeer
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IPeer Peer {get; set;}

	}
}
