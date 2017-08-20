// ReSharper disable All

namespace OpenTl.Schema.Channels
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IAdminLogResults : IObject
    {
       TVector<IChannelAdminLogEvent> Events {get; set;}

       TVector<IChat> Chats {get; set;}

       TVector<IUser> Users {get; set;}

    }
}
