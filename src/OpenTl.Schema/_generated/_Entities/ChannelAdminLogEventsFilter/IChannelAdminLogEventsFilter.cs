// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IChannelAdminLogEventsFilter : IObject
    {
       BitArray Flags {get; set;}

       bool Join {get; set;}

       bool Leave {get; set;}

       bool Invite {get; set;}

       bool Ban {get; set;}

       bool Unban {get; set;}

       bool Kick {get; set;}

       bool Unkick {get; set;}

       bool Promote {get; set;}

       bool Demote {get; set;}

       bool Info {get; set;}

       bool Settings {get; set;}

       bool Pinned {get; set;}

       bool Edit {get; set;}

       bool Delete {get; set;}

    }
}
