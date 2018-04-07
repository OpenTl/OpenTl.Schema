// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe6d83d7e)]
	public sealed class TChannelAdminLogEventActionParticipantToggleBan : IChannelAdminLogEventAction
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IChannelParticipant PrevParticipant {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IChannelParticipant NewParticipant {get; set;}

	}
}
