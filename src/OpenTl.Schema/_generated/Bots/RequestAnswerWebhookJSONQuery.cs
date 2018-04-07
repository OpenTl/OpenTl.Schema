// ReSharper disable All

namespace OpenTl.Schema.Bots
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe6213f4d)]
    public sealed class RequestAnswerWebhookJSONQuery : IRequest<bool>
    {
       [SerializationOrder(0)]
       public long QueryId {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IDataJSON Data {get; set;}

    }
}
