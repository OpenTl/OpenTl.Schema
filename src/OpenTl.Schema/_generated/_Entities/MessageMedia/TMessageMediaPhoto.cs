// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3d8ce53d)]
	public class TMessageMediaPhoto : IMessageMedia
	{
       [SerializationOrder(0)]
       public IPhoto Photo {get; set;}

       [SerializationOrder(1)]
       public string Caption {get; set;}

	}
}
