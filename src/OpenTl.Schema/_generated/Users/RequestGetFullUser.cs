namespace OpenTl.Schema.Users
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xca30a5b1)]
    public class RequestGetFullUser : IRequest<IUserFull>
    {
       [SerializationOrder(0)]
       public IInputUser Id {get; set;}

    }
}
