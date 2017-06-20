namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe3e2e1f9)]
	public class TChannelParticipantCreator : IChannelParticipant
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

	}
}
