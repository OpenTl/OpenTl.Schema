// ReSharper disable All

namespace OpenTl.Schema.Channels
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IChannelParticipant : IObject
    {
       OpenTl.Schema.IChannelParticipant Participant {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

    }
}
