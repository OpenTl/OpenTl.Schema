namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6628562c)]
    public class RequestUpdateStatus : IRequest<bool>
    {
       [SerializationOrder(0)]
       public bool Offline {get; set;}

    }
}
