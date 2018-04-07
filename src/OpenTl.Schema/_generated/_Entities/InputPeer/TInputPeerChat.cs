// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x179be863)]
	public sealed class TInputPeerChat : IInputPeer
	{
       [SerializationOrder(0)]
       public int ChatId {get; set;}

	}
}
