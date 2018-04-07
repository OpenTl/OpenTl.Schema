// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe48f964)]
	public sealed class TUpdateBotInlineSend : IUpdate
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public int UserId {get; set;}

       /// <summary>Binary representation for the 'Query' property</summary>
       [SerializationOrder(2)]
       public byte[] QueryAsBinary { get => _QueryAsBinary; set { _Query = Encoding.UTF8.GetString(value); _QueryAsBinary = value; }}
       private byte[] _QueryAsBinary;
       private string _Query;
       public string Query { get => _Query; set { QueryAsBinary = Encoding.UTF8.GetBytes(value); _Query = value; }}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.IGeoPoint Geo {get; set;}

       /// <summary>Binary representation for the 'Id' property</summary>
       [SerializationOrder(4)]
       public byte[] IdAsBinary { get => _IdAsBinary; set { _Id = Encoding.UTF8.GetString(value); _IdAsBinary = value; }}
       private byte[] _IdAsBinary;
       private string _Id;
       public string Id { get => _Id; set { IdAsBinary = Encoding.UTF8.GetBytes(value); _Id = value; }}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 1)]
       public OpenTl.Schema.IInputBotInlineMessageID MsgId {get; set;}

	}
}
