// ReSharper disable All

namespace OpenTl.Schema.Photos
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x15051f54)]
	public class TPhotosSlice : IPhotos
	{
       [SerializationOrder(0)]
       public int Count {get; set;}

       [SerializationOrder(1)]
       public TVector<IPhoto> Photos {get; set;}

       [SerializationOrder(2)]
       public TVector<IUser> Users {get; set;}

	}
}
