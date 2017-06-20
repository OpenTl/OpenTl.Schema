namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf220f3f)]
	public class TUserFull : IUserFull
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Blocked {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 4)]
       public bool PhoneCallsAvailable {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 5)]
       public bool PhoneCallsPrivate {get; set;}

       [SerializationOrder(4)]
       public IUser User {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 1)]
       public string About {get; set;}

       [SerializationOrder(6)]
       public Contacts.ILink Link {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 2)]
       public IPhoto ProfilePhoto {get; set;}

       [SerializationOrder(8)]
       public IPeerNotifySettings NotifySettings {get; set;}

       [SerializationOrder(9)]
       [CanSerialize("Flags", 3)]
       public IBotInfo BotInfo {get; set;}

       [SerializationOrder(10)]
       public int CommonChatsCount {get; set;}

	}
}
