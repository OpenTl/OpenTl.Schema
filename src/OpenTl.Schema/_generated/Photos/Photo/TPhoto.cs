// ReSharper disable All

namespace OpenTl.Schema.Photos
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x20212ca8)]
	public sealed class TPhoto : IPhoto
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IPhoto Photo {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

	}
}
