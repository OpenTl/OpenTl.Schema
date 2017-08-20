// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPhoneConnection : IObject
    {
       long Id {get; set;}

       byte[] IpAsBinary {get; set;}
       string Ip {get; set;}

       byte[] Ipv6AsBinary {get; set;}
       string Ipv6 {get; set;}

       int Port {get; set;}

       byte[] PeerTag {get; set;}

    }
}
