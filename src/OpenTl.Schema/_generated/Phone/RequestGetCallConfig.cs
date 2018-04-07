// ReSharper disable All

namespace OpenTl.Schema.Phone
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x55451fa9)]
    public sealed class RequestGetCallConfig : IRequest<OpenTl.Schema.IDataJSON>
    {

    }
}
