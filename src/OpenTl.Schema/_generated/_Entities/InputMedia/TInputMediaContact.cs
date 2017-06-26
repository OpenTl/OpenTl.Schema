// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa6e45987)]
	public class TInputMediaContact : IInputMedia
	{
       [SerializationOrder(0)]
       public string PhoneNumber {get; set;}

       [SerializationOrder(1)]
       public string FirstName {get; set;}

       [SerializationOrder(2)]
       public string LastName {get; set;}

	}
}
