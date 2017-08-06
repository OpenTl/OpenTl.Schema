// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPostAddress : IObject
    {
       byte[] StreetLine1AsBinary {get; set;}
       string StreetLine1 {get; set;}

       byte[] StreetLine2AsBinary {get; set;}
       string StreetLine2 {get; set;}

       byte[] CityAsBinary {get; set;}
       string City {get; set;}

       byte[] StateAsBinary {get; set;}
       string State {get; set;}

       byte[] CountryIso2AsBinary {get; set;}
       string CountryIso2 {get; set;}

       byte[] PostCodeAsBinary {get; set;}
       string PostCode {get; set;}

    }
}
