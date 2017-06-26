// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc7f49b7)]
	public class TPrivacyValueDisallowUsers : IPrivacyRule
	{
       [SerializationOrder(0)]
       public TVector<int> Users {get; set;}

	}
}
