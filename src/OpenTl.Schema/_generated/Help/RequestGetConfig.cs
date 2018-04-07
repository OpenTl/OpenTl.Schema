// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc4f9186b)]
    public sealed class RequestGetConfig : IRequest<OpenTl.Schema.IConfig>
    {

    }
}
