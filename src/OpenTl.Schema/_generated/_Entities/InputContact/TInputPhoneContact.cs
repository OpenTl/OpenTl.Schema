namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf392b7f4)]
	public class TInputPhoneContact : IInputContact
	{
       [SerializationOrder(0)]
       public long ClientId {get; set;}

       [SerializationOrder(1)]
       public string Phone {get; set;}

       [SerializationOrder(2)]
       public string FirstName {get; set;}

       [SerializationOrder(3)]
       public string LastName {get; set;}

	}
}
