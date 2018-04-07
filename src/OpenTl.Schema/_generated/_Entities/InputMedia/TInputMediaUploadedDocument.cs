// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5b38c6c1)]
	public sealed class TInputMediaUploadedDocument : IInputMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 3)]
       public bool NosoundVideo {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IInputFile File {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IInputFile Thumb {get; set;}

       /// <summary>Binary representation for the 'MimeType' property</summary>
       [SerializationOrder(4)]
       public byte[] MimeTypeAsBinary { get => _MimeTypeAsBinary; set { _MimeType = Encoding.UTF8.GetString(value); _MimeTypeAsBinary = value; }}
       private byte[] _MimeTypeAsBinary;
       private string _MimeType;
       public string MimeType { get => _MimeType; set { MimeTypeAsBinary = Encoding.UTF8.GetBytes(value); _MimeType = value; }}

       [SerializationOrder(5)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IDocumentAttribute> Attributes {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputDocument> Stickers {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 1)]
       public int TtlSeconds {get; set;}

	}
}
