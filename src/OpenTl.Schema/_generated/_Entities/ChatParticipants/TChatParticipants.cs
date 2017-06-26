// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3f460fed)]
	public class TChatParticipants : IChatParticipants
	{
       [SerializationOrder(0)]
       public int ChatId {get; set;}

       [SerializationOrder(1)]
       public TVector<IChatParticipant> Participants {get; set;}

       [SerializationOrder(2)]
       public int Version {get; set;}

	}
}
