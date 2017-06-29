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

        TVector<IChat> Chats {get; set;}

        TVector<IUser> Users {get; set;}

    }
}
