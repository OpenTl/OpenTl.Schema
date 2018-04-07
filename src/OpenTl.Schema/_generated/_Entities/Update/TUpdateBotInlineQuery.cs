// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x54826690)]
	public sealed class TUpdateBotInlineQuery : IUpdate
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public long QueryId {get; set;}

       [SerializationOrder(2)]
       public int UserId {get; set;}

       /// <summary>Binary representation for the 'Query' property</summary>
       [SerializationOrder(3)]
       public byte[] QueryAsBinary { get => _QueryAsBinary; set { _Query = Encoding.UTF8.GetString(value); _QueryAsBinary = value; }}
       private byte[] _QueryAsBinary;
       private string _Query;
       public string Query { get => _Query; set { QueryAsBinary = Encoding.UTF8.GetBytes(value); _Query = value; }}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.IGeoPoint Geo {get; set;}

       /// <summary>Binary representation for the 'Offset' property</summary>
       [SerializationOrder(5)]
       public byte[] OffsetAsBinary { get => _OffsetAsBinary; set { _Offset = Encoding.UTF8.GetString(value); _OffsetAsBinary = value; }}
       private byte[] _OffsetAsBinary;
       private string _Offset;
       public string Offset { get => _Offset; set { OffsetAsBinary = Encoding.UTF8.GetBytes(value); _Offset = value; }}

	}
}
