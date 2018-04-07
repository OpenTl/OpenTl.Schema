// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe254d64e)]
    public sealed class RequestGetPinnedDialogs : IRequest<OpenTl.Schema.Messages.IPeerDialogs>
    {

    }
}
