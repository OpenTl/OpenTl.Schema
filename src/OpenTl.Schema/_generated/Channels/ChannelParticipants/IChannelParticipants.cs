// ReSharper disable All

namespace OpenTl.Schema.Channels
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IChannelParticipants : IObject
    {
       int Count {get; set;}

       TVector<IChannelParticipant> Participants {get; set;}

       TVector<IUser> Users {get; set;}

    }
}
