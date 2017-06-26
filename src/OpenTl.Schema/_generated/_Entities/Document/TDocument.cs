// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x87232bc7)]
	public class TDocument : IDocument
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

       [SerializationOrder(1)]
       public long AccessHash {get; set;}

       [SerializationOrder(2)]
       public int Date {get; set;}

       [SerializationOrder(3)]
       public string MimeType {get; set;}

       [SerializationOrder(4)]
       public int Size {get; set;}

       [SerializationOrder(5)]
       public IPhotoSize Thumb {get; set;}

       [SerializationOrder(6)]
       public int DcId {get; set;}

       [SerializationOrder(7)]
       public int Version {get; set;}

       [SerializationOrder(8)]
       public TVector<IDocumentAttribute> Attributes {get; set;}

	}
}
