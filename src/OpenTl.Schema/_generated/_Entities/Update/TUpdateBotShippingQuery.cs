// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe0cdc940)]
	public class TUpdateBotShippingQuery : IUpdate
	{
       [SerializationOrder(0)]
       public long QueryId {get; set;}

       [SerializationOrder(1)]
       public int UserId {get; set;}

       [SerializationArrayLength(-1)]
       [SerializationOrder(2)]
       public byte[] Payload {get; set;}

       [SerializationOrder(3)]
       public IPostAddress ShippingAddress {get; set;}

	}
}
