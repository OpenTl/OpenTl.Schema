// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IResPQ : IObject
    {
       byte[] Nonce {get; set;}

       byte[] ServerNonce {get; set;}

       byte[] PqAsBinary {get; set;}
       string Pq {get; set;}

       OpenTl.Schema.TVector<long> ServerPublicKeyFingerprints {get; set;}

    }
}
