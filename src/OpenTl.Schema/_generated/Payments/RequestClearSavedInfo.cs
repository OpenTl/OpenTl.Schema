// ReSharper disable All

namespace OpenTl.Schema.Payments
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd83d70c1)]
    public sealed class RequestClearSavedInfo : IRequest<bool>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Credentials {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Info {get; set;}

    }
}
