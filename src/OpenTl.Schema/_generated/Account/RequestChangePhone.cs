namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x70c32edb)]
    public class RequestChangePhone : IRequest<IUser>
    {
       [SerializationOrder(0)]
       public string PhoneNumber {get; set;}

       [SerializationOrder(1)]
       public string PhoneCodeHash {get; set;}

       [SerializationOrder(2)]
       public string PhoneCode {get; set;}

    }
}
