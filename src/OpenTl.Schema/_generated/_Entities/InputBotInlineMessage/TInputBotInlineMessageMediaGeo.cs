// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf4a59de1)]
	public class TInputBotInlineMessageMediaGeo : IInputBotInlineMessage
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputGeoPoint GeoPoint {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IReplyMarkup ReplyMarkup {get; set;}

	}
}
