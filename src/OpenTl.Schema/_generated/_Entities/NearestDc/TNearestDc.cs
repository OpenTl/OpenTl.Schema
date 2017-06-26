// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8e1a1775)]
	public class TNearestDc : INearestDc
	{
       [SerializationOrder(0)]
       public string Country {get; set;}

       [SerializationOrder(1)]
       public int ThisDc {get; set;}

       [SerializationOrder(2)]
       public int NearestDc {get; set;}

	}
}
