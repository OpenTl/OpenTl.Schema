// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9f2221c9)]
	public sealed class TInputWebFileGeoPointLocation : IInputWebFileLocation
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputGeoPoint GeoPoint {get; set;}

       [SerializationOrder(1)]
       public long AccessHash {get; set;}

       [SerializationOrder(2)]
       public int W {get; set;}

       [SerializationOrder(3)]
       public int H {get; set;}

       [SerializationOrder(4)]
       public int Zoom {get; set;}

       [SerializationOrder(5)]
       public int Scale {get; set;}

	}
}
