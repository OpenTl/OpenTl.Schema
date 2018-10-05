// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9cd4eaf9)]
    public sealed class RequestGetPasswordSettings : IRequest<OpenTl.Schema.Account.IPasswordSettings>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputCheckPasswordSRP Password {get; set;}

    }
}
