// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3b831c66)]
    public class RequestGetFullChat : IRequest<Messages.IChatFull>
    {
       [SerializationOrder(0)]
       public int ChatId {get; set;}

    }
}
