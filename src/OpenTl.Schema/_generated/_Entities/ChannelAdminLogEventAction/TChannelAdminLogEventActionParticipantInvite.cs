// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe31c34d8)]
	public class TChannelAdminLogEventActionParticipantInvite : IChannelAdminLogEventAction
	{
       [SerializationOrder(0)]
       public IChannelParticipant Participant {get; set;}

	}
}
