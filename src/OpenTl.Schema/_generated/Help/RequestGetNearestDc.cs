// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1fb33026)]
    public sealed class RequestGetNearestDc : IRequest<OpenTl.Schema.INearestDc>
    {

    }
}
