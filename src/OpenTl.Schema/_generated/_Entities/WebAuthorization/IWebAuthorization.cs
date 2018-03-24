// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IWebAuthorization : IObject
    {
       long Hash {get; set;}

       int BotId {get; set;}

       byte[] DomainAsBinary {get; set;}
       string Domain {get; set;}

       byte[] BrowserAsBinary {get; set;}
       string Browser {get; set;}

       byte[] PlatformAsBinary {get; set;}
       string Platform {get; set;}

       int DateCreated {get; set;}

       int DateActive {get; set;}

       byte[] IpAsBinary {get; set;}
       string Ip {get; set;}

       byte[] RegionAsBinary {get; set;}
       string Region {get; set;}

    }
}
