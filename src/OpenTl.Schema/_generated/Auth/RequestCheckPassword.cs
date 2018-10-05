// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd18b4d16)]
    public sealed class RequestCheckPassword : IRequest<OpenTl.Schema.Auth.IAuthorization>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputCheckPasswordSRP Password {get; set;}

    }
}
