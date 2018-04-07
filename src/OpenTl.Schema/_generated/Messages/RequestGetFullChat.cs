// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3b831c66)]
    public sealed class RequestGetFullChat : IRequest<OpenTl.Schema.Messages.IChatFull>
    {
       [SerializationOrder(0)]
       public int ChatId {get; set;}

    }
}
