// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IDialog : IObject
    {
       BitArray Flags {get; set;}

       bool Pinned {get; set;}

       bool UnreadMark {get; set;}

       OpenTl.Schema.IPeer Peer {get; set;}

       int TopMessage {get; set;}

       int ReadInboxMaxId {get; set;}

       int ReadOutboxMaxId {get; set;}

       int UnreadCount {get; set;}

       int UnreadMentionsCount {get; set;}

       OpenTl.Schema.IPeerNotifySettings NotifySettings {get; set;}

       int Pts {get; set;}

       OpenTl.Schema.IDraftMessage Draft {get; set;}

    }
}
