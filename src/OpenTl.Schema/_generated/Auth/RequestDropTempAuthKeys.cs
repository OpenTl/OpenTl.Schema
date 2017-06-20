namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8e48a188)]
    public class RequestDropTempAuthKeys : IRequest<bool>
    {
       [SerializationOrder(0)]
       public TVector<long> ExceptAuthKeys {get; set;}

    }
}
