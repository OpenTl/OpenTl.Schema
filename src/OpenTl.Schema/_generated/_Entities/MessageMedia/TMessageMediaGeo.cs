// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x56e0d474)]
	public class TMessageMediaGeo : IMessageMedia
	{
       [SerializationOrder(0)]
       public IGeoPoint Geo {get; set;}

	}
}
