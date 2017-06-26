// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x131cc67f)]
	public class TInputPrivacyValueAllowUsers : IInputPrivacyRule
	{
       [SerializationOrder(0)]
       public TVector<IInputUser> Users {get; set;}

	}
}
