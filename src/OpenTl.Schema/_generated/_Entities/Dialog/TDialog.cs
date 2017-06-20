namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x66ffba14)]
	public class TDialog : IDialog
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 2)]
       public bool Pinned {get; set;}

       [SerializationOrder(2)]
       public IPeer Peer {get; set;}

       [SerializationOrder(3)]
       public int TopMessage {get; set;}

       [SerializationOrder(4)]
       public int ReadInboxMaxId {get; set;}

       [SerializationOrder(5)]
       public int ReadOutboxMaxId {get; set;}

       [SerializationOrder(6)]
       public int UnreadCount {get; set;}

       [SerializationOrder(7)]
       public IPeerNotifySettings NotifySettings {get; set;}

       [SerializationOrder(8)]
       [CanSerialize("Flags", 0)]
       public int Pts {get; set;}

       [SerializationOrder(9)]
       [CanSerialize("Flags", 1)]
       public IDraftMessage Draft {get; set;}

	}
}
