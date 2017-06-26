// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9c2dd95)]
    public class RequestSetBotPrecheckoutResults : IRequest<bool>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool Success {get; set;}

       [SerializationOrder(2)]
       public long QueryId {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public string Error {get; set;}

    }
}
