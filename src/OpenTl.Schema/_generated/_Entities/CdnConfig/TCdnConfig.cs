// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5725e40a)]
	public sealed class TCdnConfig : ICdnConfig
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.ICdnPublicKey> PublicKeys {get; set;}

	}
}
