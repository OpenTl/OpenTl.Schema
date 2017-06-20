namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3dc4b4f0)]
    public class RequestInvokeAfterMsgs : IRequest<IObject>
    {
       [SerializationOrder(0)]
       public TVector<long> MsgIds {get; set;}

       [SerializationOrder(1)]
       public IObject Query {get; set;}

    }
}
