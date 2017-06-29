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

        int Id {get; set;}

        string IpAddress {get; set;}

        int Port {get; set;}

    }
}
