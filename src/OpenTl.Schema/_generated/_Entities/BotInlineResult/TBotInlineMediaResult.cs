namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x17db940b)]
	public class TBotInlineMediaResult : IBotInlineResult
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public string Id {get; set;}

       [SerializationOrder(2)]
       public string Type {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public IPhoto Photo {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 1)]
       public IDocument Document {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 2)]
       public string Title {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 3)]
       public string Description {get; set;}

       [SerializationOrder(7)]
       public IBotInlineMessage SendMessage {get; set;}

	}
}
