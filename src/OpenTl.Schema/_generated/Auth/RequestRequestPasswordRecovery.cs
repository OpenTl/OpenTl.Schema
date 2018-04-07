// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd897bc66)]
    public sealed class RequestRequestPasswordRecovery : IRequest<OpenTl.Schema.Auth.IPasswordRecovery>
    {

    }
}
