// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xae2de196)]
    public class RequestGetAppUpdate : IRequest<Help.IAppUpdate>
    {

    }
}
