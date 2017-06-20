namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb8bc5b0c)]
	public class TInputNotifyPeer : IInputNotifyPeer
	{
       [SerializationOrder(0)]
       public IInputPeer Peer {get; set;}

	}
}
