// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x95313b0c)]
	public sealed class TUpdateUserPhoto : IUpdate
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

       [SerializationOrder(1)]
       public int Date {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IUserProfilePhoto Photo {get; set;}

       [SerializationOrder(3)]
       public bool Previous {get; set;}

	}
}
