// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x365275f2)]
    public sealed class RequestInvokeWithMessagesRange : IRequest<IObject>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IMessageRange Range {get; set;}

       [SerializationOrder(1)]
       public IObject Query {get; set;}

    }
}
