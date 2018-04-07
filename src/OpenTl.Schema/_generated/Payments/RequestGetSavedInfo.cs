// ReSharper disable All

namespace OpenTl.Schema.Payments
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x227d824b)]
    public sealed class RequestGetSavedInfo : IRequest<OpenTl.Schema.Payments.ISavedInfo>
    {

    }
}
