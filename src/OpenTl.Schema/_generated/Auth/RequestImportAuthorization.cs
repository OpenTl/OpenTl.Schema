// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe3ef9613)]
    public sealed class RequestImportAuthorization : IRequest<OpenTl.Schema.Auth.IAuthorization>
    {
       [SerializationOrder(0)]
       public int Id {get; set;}

       [SerializationOrder(1)]
       public byte[] Bytes {get; set;}

    }
}
