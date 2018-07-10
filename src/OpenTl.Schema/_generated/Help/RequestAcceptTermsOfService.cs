// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xee72f79a)]
    public sealed class RequestAcceptTermsOfService : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IDataJSON Id {get; set;}

    }
}
