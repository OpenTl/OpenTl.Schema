namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x52029342)]
    public class RequestGetCdnConfig : IRequest<ICdnConfig>
    {

    }
}
