// ReSharper disable All

namespace OpenTl.Schema.Updates
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IChannelDifferenceCommon : IObject
    {
       BitArray Flags {get; set;}

       bool Final {get; set;}

       int Pts {get; set;}

       int Timeout {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IChat> Chats {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

    }
}
