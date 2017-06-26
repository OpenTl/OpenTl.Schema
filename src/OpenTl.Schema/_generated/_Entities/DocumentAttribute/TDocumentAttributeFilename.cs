// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x15590068)]
	public class TDocumentAttributeFilename : IDocumentAttribute
	{
       [SerializationOrder(0)]
       public string FileName {get; set;}

	}
}
