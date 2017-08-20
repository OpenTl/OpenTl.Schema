// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IChatFull : IObject
    {
       int Id {get; set;}

       IPhoto ChatPhoto {get; set;}

       IPeerNotifySettings NotifySettings {get; set;}

       IExportedChatInvite ExportedInvite {get; set;}

       TVector<IBotInfo> BotInfo {get; set;}

    }
}
