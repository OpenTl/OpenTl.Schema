// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x76a6d327)]
	public class TMessageEntityTextUrl : IMessageEntity
	{
       [SerializationOrder(0)]
       public int Offset {get; set;}

       [SerializationOrder(1)]
       public int Length {get; set;}

       [SerializationOrder(2)]
       public string Url {get; set;}

	}
}
