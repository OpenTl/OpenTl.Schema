// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe320c158)]
    public class RequestGetAuthorizations : IRequest<Account.IAuthorizations>
    {

    }
}
