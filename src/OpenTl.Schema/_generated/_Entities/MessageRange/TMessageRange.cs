// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xae30253)]
	public sealed class TMessageRange : IMessageRange
	{
       [SerializationOrder(0)]
       public int MinId {get; set;}

       [SerializationOrder(1)]
       public int MaxId {get; set;}

	}
}
