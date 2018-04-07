// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xee3b272a)]
	public sealed class TUpdatePrivacy : IUpdate
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IPrivacyKey Key {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IPrivacyRule> Rules {get; set;}

	}
}
