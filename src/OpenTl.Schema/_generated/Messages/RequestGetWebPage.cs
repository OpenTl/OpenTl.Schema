namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x32ca8f91)]
    public class RequestGetWebPage : IRequest<IWebPage>
    {
       [SerializationOrder(0)]
       public string Url {get; set;}

       [SerializationOrder(1)]
       public int Hash {get; set;}

    }
}
