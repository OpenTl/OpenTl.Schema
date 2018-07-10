// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc88974ac)]
	public sealed class TChannel : IChat
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Creator {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 2)]
       public bool Left {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 3)]
       public bool Editor {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 5)]
       public bool Broadcast {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 7)]
       public bool Verified {get; set;}

       [SerializationOrder(6)]
       [FromFlag("Flags", 8)]
       public bool Megagroup {get; set;}

       [SerializationOrder(7)]
       [FromFlag("Flags", 9)]
       public bool Restricted {get; set;}

       [SerializationOrder(8)]
       [FromFlag("Flags", 10)]
       public bool Democracy {get; set;}

       [SerializationOrder(9)]
       [FromFlag("Flags", 11)]
       public bool Signatures {get; set;}

       [SerializationOrder(10)]
       [FromFlag("Flags", 12)]
       public bool Min {get; set;}

       [SerializationOrder(11)]
       public int Id {get; set;}

       [SerializationOrder(12)]
       [CanSerialize("Flags", 13)]
       public long AccessHash {get; set;}

       /// <summary>Binary representation for the 'Title' property</summary>
       [SerializationOrder(13)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       /// <summary>Binary representation for the 'Username' property</summary>
       [SerializationOrder(14)]
       [CanSerialize("Flags", 6)]
       public byte[] UsernameAsBinary { get => _UsernameAsBinary; set { _Username = Encoding.UTF8.GetString(value); _UsernameAsBinary = value; }}
       private byte[] _UsernameAsBinary;
       private string _Username;
       public string Username { get => _Username; set { UsernameAsBinary = Encoding.UTF8.GetBytes(value); _Username = value; }}

       [SerializationOrder(15)]
       public OpenTl.Schema.IChatPhoto Photo {get; set;}

       [SerializationOrder(16)]
       public int Date {get; set;}

       [SerializationOrder(17)]
       public int Version {get; set;}

       /// <summary>Binary representation for the 'RestrictionReason' property</summary>
       [SerializationOrder(18)]
       [CanSerialize("Flags", 9)]
       public byte[] RestrictionReasonAsBinary { get => _RestrictionReasonAsBinary; set { _RestrictionReason = Encoding.UTF8.GetString(value); _RestrictionReasonAsBinary = value; }}
       private byte[] _RestrictionReasonAsBinary;
       private string _RestrictionReason;
       public string RestrictionReason { get => _RestrictionReason; set { RestrictionReasonAsBinary = Encoding.UTF8.GetBytes(value); _RestrictionReason = value; }}

       [SerializationOrder(19)]
       [CanSerialize("Flags", 14)]
       public OpenTl.Schema.IChannelAdminRights AdminRights {get; set;}

       [SerializationOrder(20)]
       [CanSerialize("Flags", 15)]
       public OpenTl.Schema.IChannelBannedRights BannedRights {get; set;}

       [SerializationOrder(21)]
       [CanSerialize("Flags", 17)]
       public int ParticipantsCount {get; set;}

	}
}
