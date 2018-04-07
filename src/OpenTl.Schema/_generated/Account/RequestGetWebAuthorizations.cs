// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x182e6d6f)]
    public sealed class RequestGetWebAuthorizations : IRequest<OpenTl.Schema.Account.IWebAuthorizations>
    {

    }
}
