// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IAuthorization : IObject
    {
       long Hash {get; set;}

       int Flags {get; set;}

       byte[] DeviceModelAsBinary {get; set;}
       string DeviceModel {get; set;}

       byte[] PlatformAsBinary {get; set;}
       string Platform {get; set;}

       byte[] SystemVersionAsBinary {get; set;}
       string SystemVersion {get; set;}

       int ApiId {get; set;}

       byte[] AppNameAsBinary {get; set;}
       string AppName {get; set;}

       byte[] AppVersionAsBinary {get; set;}
       string AppVersion {get; set;}

       int DateCreated {get; set;}

       int DateActive {get; set;}

       byte[] IpAsBinary {get; set;}
       string Ip {get; set;}

       byte[] CountryAsBinary {get; set;}
       string Country {get; set;}

       byte[] RegionAsBinary {get; set;}
       string Region {get; set;}

    }
}
