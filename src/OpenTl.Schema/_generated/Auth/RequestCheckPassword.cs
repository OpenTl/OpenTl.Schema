namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa63011e)]
    public class RequestCheckPassword : IRequest<Auth.IAuthorization>
    {
       [SerializationArrayLength(-1)]
       [SerializationOrder(0)]
       public byte[] PasswordHash {get; set;}

    }
}
