// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2e13f4c3)]
	public class TUser : IUser
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 10)]
       public bool Self {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 11)]
       public bool Contact {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 12)]
       public bool MutualContact {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 13)]
       public bool Deleted {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 14)]
       public bool Bot {get; set;}

       [SerializationOrder(6)]
       [FromFlag("Flags", 15)]
       public bool BotChatHistory {get; set;}

       [SerializationOrder(7)]
       [FromFlag("Flags", 16)]
       public bool BotNochats {get; set;}

       [SerializationOrder(8)]
       [FromFlag("Flags", 17)]
       public bool Verified {get; set;}

       [SerializationOrder(9)]
       [FromFlag("Flags", 18)]
       public bool Restricted {get; set;}

       [SerializationOrder(10)]
       [FromFlag("Flags", 20)]
       public bool Min {get; set;}

       [SerializationOrder(11)]
       [FromFlag("Flags", 21)]
       public bool BotInlineGeo {get; set;}

       [SerializationOrder(12)]
       public int Id {get; set;}

       [SerializationOrder(13)]
       [CanSerialize("Flags", 0)]
       public long AccessHash {get; set;}

       [SerializationOrder(14)]
       [CanSerialize("Flags", 1)]
       public string FirstName {get; set;}

       [SerializationOrder(15)]
       [CanSerialize("Flags", 2)]
       public string LastName {get; set;}

       [SerializationOrder(16)]
       [CanSerialize("Flags", 3)]
       public string Username {get; set;}

       [SerializationOrder(17)]
       [CanSerialize("Flags", 4)]
       public string Phone {get; set;}

       [SerializationOrder(18)]
       [CanSerialize("Flags", 5)]
       public IUserProfilePhoto Photo {get; set;}

       [SerializationOrder(19)]
       [CanSerialize("Flags", 6)]
       public IUserStatus Status {get; set;}

       [SerializationOrder(20)]
       [CanSerialize("Flags", 14)]
       public int BotInfoVersion {get; set;}

       [SerializationOrder(21)]
       [CanSerialize("Flags", 18)]
       public string RestrictionReason {get; set;}

       [SerializationOrder(22)]
       [CanSerialize("Flags", 19)]
       public string BotInlinePlaceholder {get; set;}

       [SerializationOrder(23)]
       [CanSerialize("Flags", 22)]
       public string LangCode {get; set;}

	}
}
