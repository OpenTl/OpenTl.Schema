// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4d392343)]
    public class RequestGetInviteText : IRequest<Help.IInviteText>
    {

    }
}
