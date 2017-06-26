// ReSharper disable All

namespace OpenTl.Schema.Updates
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4afe8f6d)]
	public class TDifferenceTooLong : IDifference
	{
       [SerializationOrder(0)]
       public int Pts {get; set;}

	}
}
