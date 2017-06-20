namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcb9f372d)]
    public class RequestInvokeAfterMsg : IRequest<IObject>
    {
       [SerializationOrder(0)]
       public long MsgId {get; set;}

       [SerializationOrder(1)]
       public IObject Query {get; set;}

    }
}
