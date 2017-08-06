// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x95cb5f57)]
	public class TChannelFull : IChatFull
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
       public int Id {get; set;}

       [SerializationOrder(4)]
       public byte[] AboutAsBinary { get => _AboutAsBinary; set { _About = Encoding.UTF8.GetString(value); _AboutAsBinary = value; }}
       private byte[] _AboutAsBinary;
       private string _About;
       public string About { get => _About; set { AboutAsBinary = Encoding.UTF8.GetBytes(value); _About = value; }}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 0)]
       public int ParticipantsCount {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 1)]
       public int AdminsCount {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 2)]
       public int KickedCount {get; set;}

       [SerializationOrder(8)]
       [CanSerialize("Flags", 2)]
       public int BannedCount {get; set;}

       [SerializationOrder(9)]
       public int ReadInboxMaxId {get; set;}

       [SerializationOrder(10)]
       public int ReadOutboxMaxId {get; set;}

       [SerializationOrder(11)]
       public int UnreadCount {get; set;}

       [SerializationOrder(12)]
       public IPhoto ChatPhoto {get; set;}

       [SerializationOrder(13)]
       public IPeerNotifySettings NotifySettings {get; set;}

       [SerializationOrder(14)]
       public IExportedChatInvite ExportedInvite {get; set;}

       [SerializationOrder(15)]
       public TVector<IBotInfo> BotInfo {get; set;}

       [SerializationOrder(16)]
       [CanSerialize("Flags", 4)]
       public int MigratedFromChatId {get; set;}

       [SerializationOrder(17)]
       [CanSerialize("Flags", 4)]
       public int MigratedFromMaxId {get; set;}

       [SerializationOrder(18)]
       [CanSerialize("Flags", 5)]
       public int PinnedMsgId {get; set;}

	}
}
