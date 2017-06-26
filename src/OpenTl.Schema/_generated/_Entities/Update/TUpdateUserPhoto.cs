// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x95313b0c)]
	public class TUpdateUserPhoto : IUpdate
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

       [SerializationOrder(1)]
       public int Date {get; set;}

       [SerializationOrder(2)]
       public IUserProfilePhoto Photo {get; set;}

       [SerializationOrder(3)]
       public bool Previous {get; set;}

	}
}
