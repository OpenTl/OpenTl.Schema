// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa3b54985)]
	public class TChannelParticipantsKicked : IChannelParticipantsFilter
	{
       [SerializationOrder(0)]
       public string Q {get; set;}

	}
}
