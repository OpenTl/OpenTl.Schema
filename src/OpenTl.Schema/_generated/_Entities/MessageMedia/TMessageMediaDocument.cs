// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf3e02ea8)]
	public class TMessageMediaDocument : IMessageMedia
	{
       [SerializationOrder(0)]
       public IDocument Document {get; set;}

       [SerializationOrder(1)]
       public string Caption {get; set;}

	}
}
