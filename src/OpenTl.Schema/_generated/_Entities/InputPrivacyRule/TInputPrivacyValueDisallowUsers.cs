namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x90110467)]
	public class TInputPrivacyValueDisallowUsers : IInputPrivacyRule
	{
       [SerializationOrder(0)]
       public TVector<IInputUser> Users {get; set;}

	}
}
