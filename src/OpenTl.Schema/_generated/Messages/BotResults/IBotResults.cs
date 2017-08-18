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

       IInlineBotSwitchPM SwitchPm {get; set;}

       TVector<IBotInlineResult> Results {get; set;}

       int CacheTime {get; set;}

    }
}
