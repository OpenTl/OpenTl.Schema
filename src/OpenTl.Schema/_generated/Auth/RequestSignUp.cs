namespace OpenTl.Schema.Auth
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1b067634)]
    public class RequestSignUp : IRequest<Auth.IAuthorization>
    {
       [SerializationOrder(0)]
       public string PhoneNumber {get; set;}

       [SerializationOrder(1)]
       public string PhoneCodeHash {get; set;}

       [SerializationOrder(2)]
       public string PhoneCode {get; set;}

       [SerializationOrder(3)]
       public string FirstName {get; set;}

       [SerializationOrder(4)]
       public string LastName {get; set;}

    }
}
