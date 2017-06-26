// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xaaafadc8)]
	public class TInputBotInlineMessageMediaVenue : IInputBotInlineMessage
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public IInputGeoPoint GeoPoint {get; set;}

       [SerializationOrder(2)]
       public string Title {get; set;}

       [SerializationOrder(3)]
       public string Address {get; set;}

       [SerializationOrder(4)]
       public string Provider {get; set;}

       [SerializationOrder(5)]
       public string VenueId {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 2)]
       public IReplyMarkup ReplyMarkup {get; set;}

	}
}
