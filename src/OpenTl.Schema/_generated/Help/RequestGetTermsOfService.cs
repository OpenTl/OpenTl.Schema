// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x350170f3)]
    public sealed class RequestGetTermsOfService : IRequest<OpenTl.Schema.Help.ITermsOfService>
    {

    }
}
