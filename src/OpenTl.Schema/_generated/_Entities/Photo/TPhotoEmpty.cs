// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2331b22d)]
	public class TPhotoEmpty : IPhoto
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

	}
}
