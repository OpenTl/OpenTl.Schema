// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9bed434d)]
	public class TInputWebDocument : IInputWebDocument
	{
       [SerializationOrder(0)]
       public string Url {get; set;}

       [SerializationOrder(1)]
       public int Size {get; set;}

       [SerializationOrder(2)]
       public string MimeType {get; set;}

       [SerializationOrder(3)]
       public TVector<IDocumentAttribute> Attributes {get; set;}

	}
}
