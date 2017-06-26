// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x25223e24)]
    public class RequestGetWebPagePreview : IRequest<IMessageMedia>
    {
       [SerializationOrder(0)]
       public string Message {get; set;}

    }
}
