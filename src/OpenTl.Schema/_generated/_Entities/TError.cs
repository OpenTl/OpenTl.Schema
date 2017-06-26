// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc4b9f9bb)]
	public class TError : IObject
	{
       [SerializationOrder(0)]
       public int Code {get; set;}

       [SerializationOrder(1)]
       public string Text {get; set;}

	}
}
