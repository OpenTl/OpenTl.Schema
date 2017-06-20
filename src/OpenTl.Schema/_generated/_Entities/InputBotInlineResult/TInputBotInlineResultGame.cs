namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4fa417f2)]
	public class TInputBotInlineResultGame : IInputBotInlineResult
	{
       [SerializationOrder(0)]
       public string Id {get; set;}

       [SerializationOrder(1)]
       public string ShortName {get; set;}

       [SerializationOrder(2)]
       public IInputBotInlineMessage SendMessage {get; set;}

	}
}
