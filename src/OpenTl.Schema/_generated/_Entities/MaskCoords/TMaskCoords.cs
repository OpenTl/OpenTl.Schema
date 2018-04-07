// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xaed6dbb2)]
	public sealed class TMaskCoords : IMaskCoords
	{
       [SerializationOrder(0)]
       public int N {get; set;}

       [SerializationOrder(1)]
       public double X {get; set;}

       [SerializationOrder(2)]
       public double Y {get; set;}

       [SerializationOrder(3)]
       public double Zoom {get; set;}

	}
}
