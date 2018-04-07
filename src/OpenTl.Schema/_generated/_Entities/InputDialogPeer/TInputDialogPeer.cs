// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xfcaafeb7)]
	public sealed class TInputDialogPeer : IInputDialogPeer
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

	}
}
