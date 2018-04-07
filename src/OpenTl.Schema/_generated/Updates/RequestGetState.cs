// ReSharper disable All

namespace OpenTl.Schema.Updates
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xedd4882a)]
    public sealed class RequestGetState : IRequest<OpenTl.Schema.Updates.IState>
    {

    }
}
