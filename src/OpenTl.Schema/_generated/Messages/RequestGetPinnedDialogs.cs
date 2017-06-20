namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe254d64e)]
    public class RequestGetPinnedDialogs : IRequest<Messages.IPeerDialogs>
    {

    }
}
