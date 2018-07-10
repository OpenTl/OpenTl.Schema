// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1cff7e08)]
    public sealed class RequestGetSplitRanges : IRequest<OpenTl.Schema.TVector<OpenTl.Schema.IMessageRange>>
    {

    }
}
