// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x76af5481)]
	public sealed class TChannelFull : IChatFull
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 3)]
       public bool CanViewParticipants {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 6)]
       public bool CanSetUsername {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 7)]
       public bool CanSetStickers {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 10)]
       public bool HiddenPrehistory {get; set;}

       [SerializationOrder(5)]
       public int Id {get; set;}

       /// <summary>Binary representation for the 'About' property</summary>
       [SerializationOrder(6)]
       public byte[] AboutAsBinary { get => _AboutAsBinary; set { _About = Encoding.UTF8.GetString(value); _AboutAsBinary = value; }}
       private byte[] _AboutAsBinary;
       private string _About;
       public string About { get => _About; set { AboutAsBinary = Encoding.UTF8.GetBytes(value); _About = value; }}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 0)]
       public int ParticipantsCount {get; set;}

       [SerializationOrder(8)]
       [CanSerialize("Flags", 1)]
       public int AdminsCount {get; set;}

       [SerializationOrder(9)]
       [CanSerialize("Flags", 2)]
       public int KickedCount {get; set;}

       [SerializationOrder(10)]
       [CanSerialize("Flags", 2)]
       public int BannedCount {get; set;}

       [SerializationOrder(11)]
       public int ReadInboxMaxId {get; set;}

       [SerializationOrder(12)]
       public int ReadOutboxMaxId {get; set;}

       [SerializationOrder(13)]
       public int UnreadCount {get; set;}

       [SerializationOrder(14)]
       public OpenTl.Schema.IPhoto ChatPhoto {get; set;}

       [SerializationOrder(15)]
       public OpenTl.Schema.IPeerNotifySettings NotifySettings {get; set;}

       [SerializationOrder(16)]
       public OpenTl.Schema.IExportedChatInvite ExportedInvite {get; set;}

       [SerializationOrder(17)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IBotInfo> BotInfo {get; set;}

       [SerializationOrder(18)]
       [CanSerialize("Flags", 4)]
       public int MigratedFromChatId {get; set;}

       [SerializationOrder(19)]
       [CanSerialize("Flags", 4)]
       public int MigratedFromMaxId {get; set;}

       [SerializationOrder(20)]
       [CanSerialize("Flags", 5)]
       public int PinnedMsgId {get; set;}

       [SerializationOrder(21)]
       [CanSerialize("Flags", 8)]
       public OpenTl.Schema.IStickerSet Stickerset {get; set;}

       [SerializationOrder(22)]
       [CanSerialize("Flags", 9)]
       public int AvailableMinId {get; set;}

	}
}
