// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7b1a118f)]
	public sealed class TInputMediaGeoLive : IInputMedia
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputGeoPoint GeoPoint {get; set;}

       [SerializationOrder(1)]
       public int Period {get; set;}

	}
}
