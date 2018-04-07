// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xdadbc950)]
    public sealed class RequestGetPrivacy : IRequest<OpenTl.Schema.Account.IPrivacyRules>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPrivacyKey Key {get; set;}

    }
}
