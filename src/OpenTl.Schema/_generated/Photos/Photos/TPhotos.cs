// ReSharper disable All

namespace OpenTl.Schema.Photos
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8dca6aa5)]
	public class TPhotos : IPhotos
	{
       [SerializationOrder(0)]
       public TVector<IPhoto> Photos {get; set;}

       [SerializationOrder(1)]
       public TVector<IUser> Users {get; set;}

	}
}
