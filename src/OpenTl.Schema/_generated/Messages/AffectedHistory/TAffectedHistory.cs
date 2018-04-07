// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb45c69d1)]
	public sealed class TAffectedHistory : IAffectedHistory
	{
       [SerializationOrder(0)]
       public int Pts {get; set;}

       [SerializationOrder(1)]
       public int PtsCount {get; set;}

       [SerializationOrder(2)]
       public int Offset {get; set;}

	}
}
