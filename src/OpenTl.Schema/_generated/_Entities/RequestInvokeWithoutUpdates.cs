// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbf9459b7)]
    public sealed class RequestInvokeWithoutUpdates : IRequest<IObject>
    {
       [SerializationOrder(0)]
       public IObject Query {get; set;}

    }
}
