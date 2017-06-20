namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xedb93949)]
	public class TUserStatusOnline : IUserStatus
	{
       [SerializationOrder(0)]
       public int Expires {get; set;}

	}
}
