// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x98192d61)]
	public class TChannelParticipantEditor : IChannelParticipant
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

       [SerializationOrder(1)]
       public int InviterId {get; set;}

       [SerializationOrder(2)]
       public int Date {get; set;}

	}
}
