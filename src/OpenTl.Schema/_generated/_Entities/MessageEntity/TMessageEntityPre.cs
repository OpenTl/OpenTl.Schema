// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x73924be0)]
	public class TMessageEntityPre : IMessageEntity
	{
       [SerializationOrder(0)]
       public int Offset {get; set;}

       [SerializationOrder(1)]
       public int Length {get; set;}

       [SerializationOrder(2)]
       public string Language {get; set;}

	}
}
