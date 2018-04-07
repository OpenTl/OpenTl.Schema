// ReSharper disable All

namespace OpenTl.Schema.Updates
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4afe8f6d)]
	public sealed class TDifferenceTooLong : IDifference
	{
       [SerializationOrder(0)]
       public int Pts {get; set;}

	}
}
