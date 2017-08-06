// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x554abb6f)]
	public class TPrivacyRules : IPrivacyRules
	{
       [SerializationOrder(0)]
       public TVector<IPrivacyRule> Rules {get; set;}

       [SerializationOrder(1)]
       public TVector<IUser> Users {get; set;}

	}
}
