// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa63011e)]
    public class RequestCheckPassword : IRequest<OpenTl.Schema.Auth.IAuthorization>
    {
       [SerializationOrder(0)]
       public byte[] PasswordHash {get; set;}

    }
}
