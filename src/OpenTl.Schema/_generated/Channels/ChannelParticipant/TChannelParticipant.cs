namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd0d9b163)]
	public class TChannelParticipant : IChannelParticipant
	{
       [SerializationOrder(0)]
       public IChannelParticipant Participant {get; set;}

       [SerializationOrder(1)]
       public TVector<IUser> Users {get; set;}

	}
}
