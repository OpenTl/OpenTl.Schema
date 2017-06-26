// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf9c44144)]
	public class TInputMediaGeoPoint : IInputMedia
	{
       [SerializationOrder(0)]
       public IInputGeoPoint GeoPoint {get; set;}

	}
}
