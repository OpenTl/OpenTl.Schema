// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2331b22d)]
	public sealed class TPhotoEmpty : IPhoto, IEmpty
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

	}
}
