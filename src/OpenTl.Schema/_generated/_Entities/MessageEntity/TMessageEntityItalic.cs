// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x826f8b60)]
	public class TMessageEntityItalic : IMessageEntity
	{
       [SerializationOrder(0)]
       public int Offset {get; set;}

       [SerializationOrder(1)]
       public int Length {get; set;}

	}
}
