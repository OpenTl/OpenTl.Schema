// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IServerDHParams : IObject
    {
       byte[] Nonce {get; set;}

       byte[] ServerNonce {get; set;}

    }
}
