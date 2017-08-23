// ReSharper disable All

namespace OpenTl.Schema.Channels
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IChannelParticipants : IObject
    {
       int Count {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IChannelParticipant> Participants {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

    }
}
