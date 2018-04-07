// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x36f8c871)]
	public sealed class TDocumentEmpty : IDocument, IEmpty
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

	}
}
