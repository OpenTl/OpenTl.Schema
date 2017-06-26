// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8fc711d)]
    public class RequestGetAccountTTL : IRequest<IAccountDaysTTL>
    {

    }
}
