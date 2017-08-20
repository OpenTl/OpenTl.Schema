// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IChannelBannedRights : IObject
    {
       BitArray Flags {get; set;}

       bool ViewMessages {get; set;}

       bool SendMessages {get; set;}

       bool SendMedia {get; set;}

       bool SendStickers {get; set;}

       bool SendGifs {get; set;}

       bool SendGames {get; set;}

       bool SendInline {get; set;}

       bool EmbedLinks {get; set;}

       int UntilDate {get; set;}

    }
}
