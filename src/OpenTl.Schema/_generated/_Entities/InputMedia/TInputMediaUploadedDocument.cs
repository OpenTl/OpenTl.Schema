// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe39621fd)]
	public class TInputMediaUploadedDocument : IInputMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputFile File {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IInputFile Thumb {get; set;}

       [SerializationOrder(3)]
       public byte[] MimeTypeAsBinary { get => _MimeTypeAsBinary; set { _MimeType = Encoding.UTF8.GetString(value); _MimeTypeAsBinary = value; }}
       private byte[] _MimeTypeAsBinary;
       private string _MimeType;
       public string MimeType { get => _MimeType; set { MimeTypeAsBinary = Encoding.UTF8.GetBytes(value); _MimeType = value; }}

       [SerializationOrder(4)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IDocumentAttribute> Attributes {get; set;}

       [SerializationOrder(5)]
       public byte[] CaptionAsBinary { get => _CaptionAsBinary; set { _Caption = Encoding.UTF8.GetString(value); _CaptionAsBinary = value; }}
       private byte[] _CaptionAsBinary;
       private string _Caption;
       public string Caption { get => _Caption; set { CaptionAsBinary = Encoding.UTF8.GetBytes(value); _Caption = value; }}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputDocument> Stickers {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 1)]
       public int TtlSeconds {get; set;}

	}
}
