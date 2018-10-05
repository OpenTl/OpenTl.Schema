// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa59b102f)]
    public sealed class RequestUpdatePasswordSettings : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputCheckPasswordSRP Password {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.Account.IPasswordInputSettings NewSettings {get; set;}

    }
}
