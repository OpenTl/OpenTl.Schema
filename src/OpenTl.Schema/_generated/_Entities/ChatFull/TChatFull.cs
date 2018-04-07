// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2e02a614)]
	public sealed class TChatFull : IChatFull
	{
       [SerializationOrder(0)]
       public int Id {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IChatParticipants Participants {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IPhoto ChatPhoto {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.IPeerNotifySettings NotifySettings {get; set;}

       [SerializationOrder(4)]
       public OpenTl.Schema.IExportedChatInvite ExportedInvite {get; set;}

       [SerializationOrder(5)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IBotInfo> BotInfo {get; set;}

	}
}
