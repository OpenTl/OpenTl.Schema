// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xdb74f558)]
	public class TChatInvite : IChatInvite
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Channel {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Broadcast {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 2)]
       public bool Public {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 3)]
       public bool Megagroup {get; set;}

       [SerializationOrder(5)]
       public string Title {get; set;}

       [SerializationOrder(6)]
       public IChatPhoto Photo {get; set;}

       [SerializationOrder(7)]
       public int ParticipantsCount {get; set;}

       [SerializationOrder(8)]
       [CanSerialize("Flags", 4)]
       public TVector<IUser> Participants {get; set;}

	}
}
