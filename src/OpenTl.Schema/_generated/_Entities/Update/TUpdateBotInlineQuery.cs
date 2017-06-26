// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x54826690)]
	public class TUpdateBotInlineQuery : IUpdate
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public long QueryId {get; set;}

       [SerializationOrder(2)]
       public int UserId {get; set;}

       [SerializationOrder(3)]
       public string Query {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 0)]
       public IGeoPoint Geo {get; set;}

       [SerializationOrder(5)]
       public string Offset {get; set;}

	}
}
