namespace OpenTl.Schema.Bots
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xaa2769ed)]
    public class RequestSendCustomRequest : IRequest<IDataJSON>
    {
       [SerializationOrder(0)]
       public string CustomMethod {get; set;}

       [SerializationOrder(1)]
       public IDataJSON Params {get; set;}

    }
}
