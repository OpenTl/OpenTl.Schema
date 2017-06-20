namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2e02a614)]
	public class TChatFull : IChatFull
	{
       [SerializationOrder(0)]
       public int Id {get; set;}

       [SerializationOrder(1)]
       public IChatParticipants Participants {get; set;}

       [SerializationOrder(2)]
       public IPhoto ChatPhoto {get; set;}

       [SerializationOrder(3)]
       public IPeerNotifySettings NotifySettings {get; set;}

       [SerializationOrder(4)]
       public IExportedChatInvite ExportedInvite {get; set;}

       [SerializationOrder(5)]
       public TVector<IBotInfo> BotInfo {get; set;}

	}
}
