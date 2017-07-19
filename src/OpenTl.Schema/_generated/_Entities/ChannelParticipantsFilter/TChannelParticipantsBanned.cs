// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1427a5e1)]
	public class TChannelParticipantsBanned : IChannelParticipantsFilter
	{
       [SerializationOrder(0)]
       public string Q {get; set;}

	}
}
