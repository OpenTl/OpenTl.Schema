// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ISetClientDHParamsAnswer : IObject
    {
       byte[] Nonce {get; set;}

       byte[] ServerNonce {get; set;}

    }
}
