namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc61acbd8)]
	public class TWebDocument : IWebDocument
	{
       [SerializationOrder(0)]
       public string Url {get; set;}

       [SerializationOrder(1)]
       public long AccessHash {get; set;}

       [SerializationOrder(2)]
       public int Size {get; set;}

       [SerializationOrder(3)]
       public string MimeType {get; set;}

       [SerializationOrder(4)]
       public TVector<IDocumentAttribute> Attributes {get; set;}

       [SerializationOrder(5)]
       public int DcId {get; set;}

	}
}
