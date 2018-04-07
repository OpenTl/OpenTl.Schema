// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2442485e)]
    public sealed class RequestSetAccountTTL : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IAccountDaysTTL Ttl {get; set;}

    }
}
