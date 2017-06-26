// ReSharper disable All

namespace OpenTl.Schema.Photos
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x20212ca8)]
	public class TPhoto : IPhoto
	{
       [SerializationOrder(0)]
       public IPhoto Photo {get; set;}

       [SerializationOrder(1)]
       public TVector<IUser> Users {get; set;}

	}
}
