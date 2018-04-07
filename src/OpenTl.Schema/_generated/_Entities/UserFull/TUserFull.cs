// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf220f3f)]
	public sealed class TUserFull : IUserFull
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
       public OpenTl.Schema.IUser User {get; set;}

       /// <summary>Binary representation for the 'About' property</summary>
       [SerializationOrder(5)]
       [CanSerialize("Flags", 1)]
       public byte[] AboutAsBinary { get => _AboutAsBinary; set { _About = Encoding.UTF8.GetString(value); _AboutAsBinary = value; }}
       private byte[] _AboutAsBinary;
       private string _About;
       public string About { get => _About; set { AboutAsBinary = Encoding.UTF8.GetBytes(value); _About = value; }}

       [SerializationOrder(6)]
       public OpenTl.Schema.Contacts.ILink Link {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IPhoto ProfilePhoto {get; set;}

       [SerializationOrder(8)]
       public OpenTl.Schema.IPeerNotifySettings NotifySettings {get; set;}

       [SerializationOrder(9)]
       [CanSerialize("Flags", 3)]
       public OpenTl.Schema.IBotInfo BotInfo {get; set;}

       [SerializationOrder(10)]
       public int CommonChatsCount {get; set;}

	}
}
