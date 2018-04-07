// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8e48a188)]
    public sealed class RequestDropTempAuthKeys : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<long> ExceptAuthKeys {get; set;}

    }
}
