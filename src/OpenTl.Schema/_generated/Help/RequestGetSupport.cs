namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9cdf08cd)]
    public class RequestGetSupport : IRequest<Help.ISupport>
    {

    }
}
