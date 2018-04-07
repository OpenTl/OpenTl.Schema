// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb8bc5b0c)]
	public sealed class TInputNotifyPeer : IInputNotifyPeer
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

	}
}
