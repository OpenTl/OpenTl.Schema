// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x84d19185)]
	public sealed class TAffectedMessages : IAffectedMessages
	{
       [SerializationOrder(0)]
       public int Pts {get; set;}

       [SerializationOrder(1)]
       public int PtsCount {get; set;}

	}
}
