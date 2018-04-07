// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe320c158)]
    public sealed class RequestGetAuthorizations : IRequest<OpenTl.Schema.Account.IAuthorizations>
    {

    }
}
