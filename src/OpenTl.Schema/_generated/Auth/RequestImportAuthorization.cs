// ReSharper disable All

namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe3ef9613)]
    public class RequestImportAuthorization : IRequest<Auth.IAuthorization>
    {
       [SerializationOrder(0)]
       public int Id {get; set;}

       [SerializationArrayLength(-1)]
       [SerializationOrder(1)]
       public byte[] Bytes {get; set;}

    }
}
