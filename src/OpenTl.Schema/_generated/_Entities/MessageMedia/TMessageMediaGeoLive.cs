// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7c3c2609)]
	public sealed class TMessageMediaGeoLive : IMessageMedia
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IGeoPoint Geo {get; set;}

       [SerializationOrder(1)]
       public int Period {get; set;}

	}
}
