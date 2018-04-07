// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9cdf08cd)]
    public sealed class RequestGetSupport : IRequest<OpenTl.Schema.Help.ISupport>
    {

    }
}
