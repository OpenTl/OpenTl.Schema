// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IUserFull : IObject
    {
       BitArray Flags {get; set;}

       bool Blocked {get; set;}

       bool PhoneCallsAvailable {get; set;}

       bool PhoneCallsPrivate {get; set;}

       IUser User {get; set;}

       byte[] AboutAsBinary {get; set;}
       string About {get; set;}

       Contacts.ILink Link {get; set;}

       IPhoto ProfilePhoto {get; set;}

       IPeerNotifySettings NotifySettings {get; set;}

       IBotInfo BotInfo {get; set;}

       int CommonChatsCount {get; set;}

    }
}
