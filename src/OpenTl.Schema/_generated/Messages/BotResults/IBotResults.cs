// ReSharper disable All

namespace OpenTl.Schema.Messages
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IBotResults : IObject
    {
       BitArray Flags {get; set;}

       bool Gallery {get; set;}

       long QueryId {get; set;}

       byte[] NextOffsetAsBinary {get; set;}
       string NextOffset {get; set;}

       OpenTl.Schema.IInlineBotSwitchPM SwitchPm {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IBotInlineResult> Results {get; set;}

       int CacheTime {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

    }
}
