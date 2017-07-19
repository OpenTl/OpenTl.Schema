// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x656ac4b)]
	public class TChannelParticipantsSearch : IChannelParticipantsFilter
	{
       [SerializationOrder(0)]
       public string Q {get; set;}

	}
}
