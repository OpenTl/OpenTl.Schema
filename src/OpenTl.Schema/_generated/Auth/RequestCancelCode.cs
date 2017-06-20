namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1f040578)]
    public class RequestCancelCode : IRequest<bool>
    {
       [SerializationOrder(0)]
       public string PhoneNumber {get; set;}

       [SerializationOrder(1)]
       public string PhoneCodeHash {get; set;}

    }
}
