// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x0949d9dc)]
	public sealed class TFutureSalt : IObject
	{
       [SerializationOrder(0)]
       public int ValidSince {get; set;}

       [SerializationOrder(1)]
       public int ValidUntil {get; set;}

       [SerializationOrder(2)]
       public long Salt {get; set;}

	}
}
