// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x52029342)]
    public sealed class RequestGetCdnConfig : IRequest<OpenTl.Schema.ICdnConfig>
    {

    }
}
