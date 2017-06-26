// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2cbbe15a)]
	public class TInputBotInlineResult : IInputBotInlineResult
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
       [CanSerialize("Flags", 3)]
       public string Url {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 4)]
       public string ThumbUrl {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 5)]
       public string ContentUrl {get; set;}

       [SerializationOrder(8)]
       [CanSerialize("Flags", 5)]
       public string ContentType {get; set;}

       [SerializationOrder(9)]
       [CanSerialize("Flags", 6)]
       public int W {get; set;}

       [SerializationOrder(10)]
       [CanSerialize("Flags", 6)]
       public int H {get; set;}

       [SerializationOrder(11)]
       [CanSerialize("Flags", 7)]
       public int Duration {get; set;}

       [SerializationOrder(12)]
       public IInputBotInlineMessage SendMessage {get; set;}

	}
}
