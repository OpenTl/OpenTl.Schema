namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc27ac8c7)]
	public class TBotCommand : IBotCommand
	{
       [SerializationOrder(0)]
       public string Command {get; set;}

       [SerializationOrder(1)]
       public string Description {get; set;}

	}
}
