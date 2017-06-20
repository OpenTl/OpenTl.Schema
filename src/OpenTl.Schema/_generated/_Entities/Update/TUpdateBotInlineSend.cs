namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe48f964)]
	public class TUpdateBotInlineSend : IUpdate
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public int UserId {get; set;}

       [SerializationOrder(2)]
       public string Query {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public IGeoPoint Geo {get; set;}

       [SerializationOrder(4)]
       public string Id {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 1)]
       public IInputBotInlineMessageID MsgId {get; set;}

	}
}
