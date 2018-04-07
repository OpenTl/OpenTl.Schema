// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe58e95d2)]
    public sealed class RequestDeleteMessages : IRequest<OpenTl.Schema.Messages.IAffectedMessages>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Revoke {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.TVector<int> Id {get; set;}

    }
}
