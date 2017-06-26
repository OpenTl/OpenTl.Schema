// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbdf9653b)]
	public class TGame : IGame
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public long Id {get; set;}

       [SerializationOrder(2)]
       public long AccessHash {get; set;}

       [SerializationOrder(3)]
       public string ShortName {get; set;}

       [SerializationOrder(4)]
       public string Title {get; set;}

       [SerializationOrder(5)]
       public string Description {get; set;}

       [SerializationOrder(6)]
       public IPhoto Photo {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 0)]
       public IDocument Document {get; set;}

	}
}
