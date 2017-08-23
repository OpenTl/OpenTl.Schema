// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IChatFull : IObject
    {
       int Id {get; set;}

       OpenTl.Schema.IPhoto ChatPhoto {get; set;}

       OpenTl.Schema.IPeerNotifySettings NotifySettings {get; set;}

       OpenTl.Schema.IExportedChatInvite ExportedInvite {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IBotInfo> BotInfo {get; set;}

    }
}
