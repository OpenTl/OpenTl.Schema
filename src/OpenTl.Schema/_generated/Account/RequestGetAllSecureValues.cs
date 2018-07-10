// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb288bc7d)]
    public sealed class RequestGetAllSecureValues : IRequest<OpenTl.Schema.TVector<OpenTl.Schema.ISecureValue>>
    {

    }
}
