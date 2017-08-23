// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbc8d11bb)]
    public class RequestGetPasswordSettings : IRequest<OpenTl.Schema.Account.IPasswordSettings>
    {
       [SerializationOrder(0)]
       public byte[] CurrentPasswordHash {get; set;}

    }
}
