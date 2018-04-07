// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x682d2594)]
    public sealed class RequestResetWebAuthorizations : IRequest<bool>
    {

    }
}
