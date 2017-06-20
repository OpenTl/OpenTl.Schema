namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4ea56e92)]
    public class RequestRecoverPassword : IRequest<Auth.IAuthorization>
    {
       [SerializationOrder(0)]
       public string Code {get; set;}

    }
}
