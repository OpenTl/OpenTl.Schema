// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xae636f24)]
	public class TDisabledFeature : IDisabledFeature
	{
       [SerializationOrder(0)]
       public string Feature {get; set;}

       [SerializationOrder(1)]
       public string Description {get; set;}

	}
}
