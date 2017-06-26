// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5725e40a)]
	public class TCdnConfig : ICdnConfig
	{
       [SerializationOrder(0)]
       public TVector<ICdnPublicKey> PublicKeys {get; set;}

	}
}
