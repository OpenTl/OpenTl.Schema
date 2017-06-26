// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x350170f3)]
    public class RequestGetTermsOfService : IRequest<Help.ITermsOfService>
    {

    }
}
