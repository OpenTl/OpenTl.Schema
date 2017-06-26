// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2442485e)]
    public class RequestSetAccountTTL : IRequest<bool>
    {
       [SerializationOrder(0)]
       public IAccountDaysTTL Tl {get; set;}

    }
}
