// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd0d9b163)]
	public sealed class TChannelParticipant : IChannelParticipant
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IChannelParticipant Participant {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

	}
}
