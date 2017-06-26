// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe40370a3)]
	public class TUpdateEditMessage : IUpdate
	{
       [SerializationOrder(0)]
       public IMessage Message {get; set;}

       [SerializationOrder(1)]
       public int Pts {get; set;}

       [SerializationOrder(2)]
       public int PtsCount {get; set;}

	}
}
