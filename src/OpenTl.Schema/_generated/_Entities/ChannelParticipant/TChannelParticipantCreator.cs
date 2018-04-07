// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe3e2e1f9)]
	public sealed class TChannelParticipantCreator : IChannelParticipant
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

	}
}
