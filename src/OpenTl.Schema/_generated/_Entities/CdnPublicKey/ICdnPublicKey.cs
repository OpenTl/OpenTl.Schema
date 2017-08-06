// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ICdnPublicKey : IObject
    {
       int DcId {get; set;}

       byte[] PublicKeyAsBinary {get; set;}
       string PublicKey {get; set;}

    }
}
