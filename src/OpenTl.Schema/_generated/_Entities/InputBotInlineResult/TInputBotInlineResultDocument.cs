// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xfff8fdc4)]
	public class TInputBotInlineResultDocument : IInputBotInlineResult
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public string Id {get; set;}

       [SerializationOrder(2)]
       public string Type {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public string Title {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 2)]
       public string Description {get; set;}

       [SerializationOrder(5)]
       public IInputDocument Document {get; set;}

       [SerializationOrder(6)]
       public IInputBotInlineMessage SendMessage {get; set;}

	}
}
