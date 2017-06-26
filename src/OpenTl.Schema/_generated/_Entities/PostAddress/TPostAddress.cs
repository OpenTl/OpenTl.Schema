// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1e8caaeb)]
	public class TPostAddress : IPostAddress
	{
       [SerializationOrder(0)]
       public string StreetLine1 {get; set;}

       [SerializationOrder(1)]
       public string StreetLine2 {get; set;}

       [SerializationOrder(2)]
       public string City {get; set;}

       [SerializationOrder(3)]
       public string State {get; set;}

       [SerializationOrder(4)]
       public string CountryIso2 {get; set;}

       [SerializationOrder(5)]
       public string PostCode {get; set;}

	}
}
