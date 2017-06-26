// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9fab0d1a)]
    public class RequestResetAuthorizations : IRequest<bool>
    {

    }
}
