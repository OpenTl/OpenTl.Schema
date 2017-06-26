// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8cc5e69a)]
	public class TChannelParticipantKicked : IChannelParticipant
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

       [SerializationOrder(1)]
       public int KickedBy {get; set;}

       [SerializationOrder(2)]
       public int Date {get; set;}

	}
}
