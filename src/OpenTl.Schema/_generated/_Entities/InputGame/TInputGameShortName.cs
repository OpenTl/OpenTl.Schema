namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc331e80a)]
	public class TInputGameShortName : IInputGame
	{
       [SerializationOrder(0)]
       public IInputUser BotId {get; set;}

       [SerializationOrder(1)]
       public string ShortName {get; set;}

	}
}
