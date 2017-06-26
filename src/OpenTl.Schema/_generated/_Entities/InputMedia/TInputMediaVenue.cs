// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2827a81a)]
	public class TInputMediaVenue : IInputMedia
	{
       [SerializationOrder(0)]
       public IInputGeoPoint GeoPoint {get; set;}

       [SerializationOrder(1)]
       public string Title {get; set;}

       [SerializationOrder(2)]
       public string Address {get; set;}

       [SerializationOrder(3)]
       public string Provider {get; set;}

       [SerializationOrder(4)]
       public string VenueId {get; set;}

	}
}
