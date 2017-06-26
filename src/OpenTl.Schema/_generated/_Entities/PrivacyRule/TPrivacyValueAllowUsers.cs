// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4d5bbe0c)]
	public class TPrivacyValueAllowUsers : IPrivacyRule
	{
       [SerializationOrder(0)]
       public TVector<int> Users {get; set;}

	}
}
