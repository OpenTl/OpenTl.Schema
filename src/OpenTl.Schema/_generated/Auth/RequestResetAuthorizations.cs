// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9fab0d1a)]
    public sealed class RequestResetAuthorizations : IRequest<bool>
    {

    }
}
