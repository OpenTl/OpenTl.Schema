namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2714d86c)]
    public class RequestCheckUsername : IRequest<bool>
    {
       [SerializationOrder(0)]
       public string Username {get; set;}

    }
}
