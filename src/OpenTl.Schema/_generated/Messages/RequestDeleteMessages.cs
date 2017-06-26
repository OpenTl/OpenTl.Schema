// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe58e95d2)]
    public class RequestDeleteMessages : IRequest<Messages.IAffectedMessages>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Revoke {get; set;}

       [SerializationOrder(2)]
       public TVector<int> Id {get; set;}

    }
}
