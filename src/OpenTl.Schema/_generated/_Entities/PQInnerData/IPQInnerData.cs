// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPQInnerData : IObject
    {
       byte[] PqAsBinary {get; set;}
       string Pq {get; set;}

       byte[] PAsBinary {get; set;}
       string P {get; set;}

       byte[] QAsBinary {get; set;}
       string Q {get; set;}

       byte[] Nonce {get; set;}

       byte[] ServerNonce {get; set;}

       byte[] NewNonce {get; set;}

    }
}
