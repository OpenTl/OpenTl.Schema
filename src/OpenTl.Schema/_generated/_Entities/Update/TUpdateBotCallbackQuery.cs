namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe73547e1)]
	public class TUpdateBotCallbackQuery : IUpdate
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public long QueryId {get; set;}

       [SerializationOrder(2)]
       public int UserId {get; set;}

       [SerializationOrder(3)]
       public IPeer Peer {get; set;}

       [SerializationOrder(4)]
       public int MsgId {get; set;}

       [SerializationOrder(5)]
       public long ChatInstance {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 0)]
       public byte[] Data {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 1)]
       public string GameShortName {get; set;}

	}
}
