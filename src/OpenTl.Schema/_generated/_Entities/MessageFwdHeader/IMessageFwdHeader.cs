// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IMessageFwdHeader : IObject
    {
       BitArray Flags {get; set;}

       int FromId {get; set;}

       int Date {get; set;}

       int ChannelId {get; set;}

       int ChannelPost {get; set;}

       byte[] PostAuthorAsBinary {get; set;}
       string PostAuthor {get; set;}

       OpenTl.Schema.IPeer SavedFromPeer {get; set;}

       int SavedFromMsgId {get; set;}

    }
}
