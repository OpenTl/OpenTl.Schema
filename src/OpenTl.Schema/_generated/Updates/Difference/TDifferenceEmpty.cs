// ReSharper disable All

namespace OpenTl.Schema.Updates
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5d75a138)]
	public sealed class TDifferenceEmpty : IDifference, IEmpty
	{
       [SerializationOrder(0)]
       public int Date {get; set;}

       [SerializationOrder(1)]
       public int Seq {get; set;}

	}
}
