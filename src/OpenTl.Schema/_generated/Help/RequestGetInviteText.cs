// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4d392343)]
    public sealed class RequestGetInviteText : IRequest<OpenTl.Schema.Help.IInviteText>
    {

    }
}
