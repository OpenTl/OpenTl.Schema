// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3f460fed)]
	public sealed class TChatParticipants : IChatParticipants
	{
       [SerializationOrder(0)]
       public int ChatId {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IChatParticipant> Participants {get; set;}

       [SerializationOrder(2)]
       public int Version {get; set;}

	}
}
