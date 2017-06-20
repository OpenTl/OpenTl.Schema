namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd559d8c8)]
	public class TUserProfilePhoto : IUserProfilePhoto
	{
       [SerializationOrder(0)]
       public long PhotoId {get; set;}

       [SerializationOrder(1)]
       public IFileLocation PhotoSmall {get; set;}

       [SerializationOrder(2)]
       public IFileLocation PhotoBig {get; set;}

	}
}
