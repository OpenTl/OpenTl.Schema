// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa7332b73)]
	public class TUpdateUserName : IUpdate
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

       [SerializationOrder(1)]
       public string FirstName {get; set;}

       [SerializationOrder(2)]
       public string LastName {get; set;}

       [SerializationOrder(3)]
       public string Username {get; set;}

	}
}
