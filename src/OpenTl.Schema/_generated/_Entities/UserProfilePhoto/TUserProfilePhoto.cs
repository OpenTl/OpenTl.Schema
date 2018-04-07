// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd559d8c8)]
	public sealed class TUserProfilePhoto : IUserProfilePhoto
	{
       [SerializationOrder(0)]
       public long PhotoId {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IFileLocation PhotoSmall {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IFileLocation PhotoBig {get; set;}

	}
}
