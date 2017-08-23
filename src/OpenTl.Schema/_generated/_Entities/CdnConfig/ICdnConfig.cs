// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ICdnConfig : IObject
    {
       OpenTl.Schema.TVector<OpenTl.Schema.ICdnPublicKey> PublicKeys {get; set;}

    }
}
