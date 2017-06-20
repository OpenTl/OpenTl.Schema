namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7912b71f)]
	public class TMessageMediaVenue : IMessageMedia
	{
       [SerializationOrder(0)]
       public IGeoPoint Geo {get; set;}

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
