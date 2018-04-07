// ReSharper disable All

namespace OpenTl.Schema.Updates
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6a9d7b35)]
	public sealed class TChannelDifferenceTooLong : IChannelDifference
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Final {get; set;}

       [SerializationOrder(2)]
       public int Pts {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public int Timeout {get; set;}

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
       public OpenTl.Schema.TVector<OpenTl.Schema.IMessage> Messages {get; set;}

       [SerializationOrder(10)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IChat> Chats {get; set;}

       [SerializationOrder(11)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

	}
}
