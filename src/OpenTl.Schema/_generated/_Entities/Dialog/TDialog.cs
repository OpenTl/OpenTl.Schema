// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe4def5db)]
	public sealed class TDialog : IDialog
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 2)]
       public bool Pinned {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 3)]
       public bool UnreadMark {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.IPeer Peer {get; set;}

       [SerializationOrder(4)]
       public int TopMessage {get; set;}

       [SerializationOrder(5)]
       public int ReadInboxMaxId {get; set;}

       [SerializationOrder(6)]
       public int ReadOutboxMaxId {get; set;}

       [SerializationOrder(7)]
       public int UnreadCount {get; set;}

       [SerializationOrder(8)]
       public int UnreadMentionsCount {get; set;}

       [SerializationOrder(9)]
       public OpenTl.Schema.IPeerNotifySettings NotifySettings {get; set;}

       [SerializationOrder(10)]
       [CanSerialize("Flags", 0)]
       public int Pts {get; set;}

       [SerializationOrder(11)]
       [CanSerialize("Flags", 1)]
       public OpenTl.Schema.IDraftMessage Draft {get; set;}

	}
}
