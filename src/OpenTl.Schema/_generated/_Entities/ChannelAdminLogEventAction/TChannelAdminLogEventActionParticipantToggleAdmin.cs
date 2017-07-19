// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd5676710)]
	public class TChannelAdminLogEventActionParticipantToggleAdmin : IChannelAdminLogEventAction
	{
       [SerializationOrder(0)]
       public IChannelParticipant PrevParticipant {get; set;}

       [SerializationOrder(1)]
       public IChannelParticipant NewParticipant {get; set;}

	}
}
