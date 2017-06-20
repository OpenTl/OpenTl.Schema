namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7761198)]
	public class TUpdateChatParticipants : IUpdate
	{
       [SerializationOrder(0)]
       public IChatParticipants Participants {get; set;}

	}
}
