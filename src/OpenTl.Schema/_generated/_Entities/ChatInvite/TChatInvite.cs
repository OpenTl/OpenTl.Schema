// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xdb74f558)]
	public sealed class TChatInvite : IChatInvite
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

       /// <summary>Binary representation for the 'Title' property</summary>
       [SerializationOrder(5)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       [SerializationOrder(6)]
       public OpenTl.Schema.IChatPhoto Photo {get; set;}

       [SerializationOrder(7)]
       public int ParticipantsCount {get; set;}

       [SerializationOrder(8)]
       [CanSerialize("Flags", 4)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IUser> Participants {get; set;}

	}
}
