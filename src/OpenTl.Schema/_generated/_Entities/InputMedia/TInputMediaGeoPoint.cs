// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf9c44144)]
	public sealed class TInputMediaGeoPoint : IInputMedia
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputGeoPoint GeoPoint {get; set;}

	}
}
