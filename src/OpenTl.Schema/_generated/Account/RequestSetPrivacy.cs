// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc9f81ce8)]
    public class RequestSetPrivacy : IRequest<Account.IPrivacyRules>
    {
       [SerializationOrder(0)]
       public IInputPrivacyKey Key {get; set;}

       [SerializationOrder(1)]
       public TVector<IInputPrivacyRule> Rules {get; set;}

    }
}
