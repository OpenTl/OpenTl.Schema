// ReSharper disable All

namespace OpenTl.Schema.Channels
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IAdminLogResults : IObject
    {
       OpenTl.Schema.TVector<OpenTl.Schema.IChannelAdminLogEvent> Events {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IChat> Chats {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

    }
}
