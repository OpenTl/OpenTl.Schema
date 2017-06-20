namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd897bc66)]
    public class RequestRequestPasswordRecovery : IRequest<Auth.IPasswordRecovery>
    {

    }
}
