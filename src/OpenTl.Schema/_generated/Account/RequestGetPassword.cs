// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x548a30f5)]
    public sealed class RequestGetPassword : IRequest<OpenTl.Schema.Account.IPassword>
    {

    }
}
