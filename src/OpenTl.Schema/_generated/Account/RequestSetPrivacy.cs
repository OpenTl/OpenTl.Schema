// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc9f81ce8)]
    public sealed class RequestSetPrivacy : IRequest<OpenTl.Schema.Account.IPrivacyRules>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPrivacyKey Key {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputPrivacyRule> Rules {get; set;}

    }
}
