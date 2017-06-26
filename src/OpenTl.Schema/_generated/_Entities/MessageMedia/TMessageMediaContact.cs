// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5e7d2f39)]
	public class TMessageMediaContact : IMessageMedia
	{
       [SerializationOrder(0)]
       public string PhoneNumber {get; set;}

       [SerializationOrder(1)]
       public string FirstName {get; set;}

       [SerializationOrder(2)]
       public string LastName {get; set;}

       [SerializationOrder(3)]
       public int UserId {get; set;}

	}
}
