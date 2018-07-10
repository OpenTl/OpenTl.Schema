// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IIpPort : IObject
    {
       int Ipv4 {get; set;}

       int Port {get; set;}

    }
}
