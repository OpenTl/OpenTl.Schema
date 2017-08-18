// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ICdnConfig : IObject
    {
       TVector<ICdnPublicKey> PublicKeys {get; set;}

    }
}
