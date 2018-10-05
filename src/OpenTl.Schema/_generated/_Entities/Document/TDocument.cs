// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x59534e4c)]
	public sealed class TDocument : IDocument
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

       [SerializationOrder(1)]
       public long AccessHash {get; set;}

       [SerializationOrder(2)]
       public byte[] FileReference {get; set;}

       [SerializationOrder(3)]
       public int Date {get; set;}

       /// <summary>Binary representation for the 'MimeType' property</summary>
       [SerializationOrder(4)]
       public byte[] MimeTypeAsBinary { get => _MimeTypeAsBinary; set { _MimeType = Encoding.UTF8.GetString(value); _MimeTypeAsBinary = value; }}
       private byte[] _MimeTypeAsBinary;
       private string _MimeType;
       public string MimeType { get => _MimeType; set { MimeTypeAsBinary = Encoding.UTF8.GetBytes(value); _MimeType = value; }}

       [SerializationOrder(5)]
       public int Size {get; set;}

       [SerializationOrder(6)]
       public OpenTl.Schema.IPhotoSize Thumb {get; set;}

       [SerializationOrder(7)]
       public int DcId {get; set;}

       [SerializationOrder(8)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IDocumentAttribute> Attributes {get; set;}

	}
}
