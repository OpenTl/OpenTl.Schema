// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2d01b9ef)]
    public sealed class RequestResetWebAuthorization : IRequest<bool>
    {
       [SerializationOrder(0)]
       public long Hash {get; set;}

    }
}
