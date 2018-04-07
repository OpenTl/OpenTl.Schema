// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xda9b0d0d)]
    public sealed class RequestInvokeWithLayer : IRequest<IObject>
    {
       [SerializationOrder(0)]
       public int Layer {get; set;}

       [SerializationOrder(1)]
       public IObject Query {get; set;}

    }
}
