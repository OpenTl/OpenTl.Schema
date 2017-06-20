namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x98e81d3a)]
	public class TBotInfo : IBotInfo
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

       [SerializationOrder(1)]
       public string Description {get; set;}

       [SerializationOrder(2)]
       public TVector<IBotCommand> Commands {get; set;}

	}
}
