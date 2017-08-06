// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPhoneCallProtocol : IObject
    {
       BitArray Flags {get; set;}

       bool UdpP2p {get; set;}

       bool UdpReflector {get; set;}

       int MinLayer {get; set;}

       int MaxLayer {get; set;}

    }
}
