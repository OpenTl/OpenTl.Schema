// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x83e5de54)]
	public class TMessageEmpty : IMessage, IEmpty
	{
       [SerializationOrder(0)]
       public int Id {get; set;}

	}
}
