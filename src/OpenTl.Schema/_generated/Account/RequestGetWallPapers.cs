// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc04cfac2)]
    public sealed class RequestGetWallPapers : IRequest<OpenTl.Schema.TVector<OpenTl.Schema.IWallPaper>>
    {

    }
}
