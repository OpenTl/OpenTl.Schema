// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IDcOption : IObject
    {
       BitArray Flags {get; set;}

       bool Ipv6 {get; set;}

       bool MediaOnly {get; set;}

       bool TcpoOnly {get; set;}

       bool Cdn {get; set;}

       bool Static {get; set;}

       int Id {get; set;}

       byte[] IpAddressAsBinary {get; set;}
       string IpAddress {get; set;}

       int Port {get; set;}

       byte[] Secret {get; set;}

    }
}
