// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xedd923c5)]
    public class RequestDiscardEncryption : IRequest<bool>
    {
       [SerializationOrder(0)]
       public int ChatId {get; set;}

    }
}
