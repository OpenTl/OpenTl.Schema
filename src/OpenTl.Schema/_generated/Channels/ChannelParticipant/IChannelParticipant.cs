// ReSharper disable All

namespace OpenTl.Schema.Channels
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IChannelParticipant : IObject
    {
       IChannelParticipant Participant {get; set;}

       TVector<IUser> Users {get; set;}

    }
}
