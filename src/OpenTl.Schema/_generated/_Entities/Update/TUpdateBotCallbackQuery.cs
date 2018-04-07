// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe73547e1)]
	public sealed class TUpdateBotCallbackQuery : IUpdate
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public long QueryId {get; set;}

       [SerializationOrder(2)]
       public int UserId {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.IPeer Peer {get; set;}

       [SerializationOrder(4)]
       public int MsgId {get; set;}

       [SerializationOrder(5)]
       public long ChatInstance {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 0)]
       public byte[] Data {get; set;}

       /// <summary>Binary representation for the 'GameShortName' property</summary>
       [SerializationOrder(7)]
       [CanSerialize("Flags", 1)]
       public byte[] GameShortNameAsBinary { get => _GameShortNameAsBinary; set { _GameShortName = Encoding.UTF8.GetString(value); _GameShortNameAsBinary = value; }}
       private byte[] _GameShortNameAsBinary;
       private string _GameShortName;
       public string GameShortName { get => _GameShortName; set { GameShortNameAsBinary = Encoding.UTF8.GetBytes(value); _GameShortName = value; }}

	}
}
