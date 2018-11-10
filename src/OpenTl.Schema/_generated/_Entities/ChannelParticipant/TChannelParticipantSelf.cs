// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[System.Serializable]
	[Serialize(0xa3289a6d)]
	public sealed class TChannelParticipantSelf : IChannelParticipant
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

       [SerializationOrder(1)]
       public int InviterId {get; set;}

       [SerializationOrder(2)]
       public int Date {get; set;}

	}
}
