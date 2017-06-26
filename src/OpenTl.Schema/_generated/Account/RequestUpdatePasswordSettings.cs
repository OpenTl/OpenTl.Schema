// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xfa7c4b86)]
    public class RequestUpdatePasswordSettings : IRequest<bool>
    {
       [SerializationArrayLength(-1)]
       [SerializationOrder(0)]
       public byte[] CurrentPasswordHash {get; set;}

       [SerializationOrder(1)]
       public Account.IPasswordInputSettings NewSettings {get; set;}

    }
}
