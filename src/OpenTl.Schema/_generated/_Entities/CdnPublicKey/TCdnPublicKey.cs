// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc982eaba)]
	public class TCdnPublicKey : ICdnPublicKey
	{
       [SerializationOrder(0)]
       public int DcId {get; set;}

       [SerializationOrder(1)]
       public string PublicKey {get; set;}

	}
}
