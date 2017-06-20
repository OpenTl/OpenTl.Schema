namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa8d864a7)]
	public class TInputBotInlineResultPhoto : IInputBotInlineResult
	{
       [SerializationOrder(0)]
       public string Id {get; set;}

       [SerializationOrder(1)]
       public string Type {get; set;}

       [SerializationOrder(2)]
       public IInputPhoto Photo {get; set;}

       [SerializationOrder(3)]
       public IInputBotInlineMessage SendMessage {get; set;}

	}
}
