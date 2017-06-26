// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xee3b272a)]
	public class TUpdatePrivacy : IUpdate
	{
       [SerializationOrder(0)]
       public IPrivacyKey Key {get; set;}

       [SerializationOrder(1)]
       public TVector<IPrivacyRule> Rules {get; set;}

	}
}
