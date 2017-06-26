// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe17e23c)]
	public class TPhotoSizeEmpty : IPhotoSize
	{
       [SerializationOrder(0)]
       public string Ype {get; set;}

	}
}
