namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xdadbc950)]
    public class RequestGetPrivacy : IRequest<Account.IPrivacyRules>
    {
       [SerializationOrder(0)]
       public IInputPrivacyKey Key {get; set;}

    }
}
