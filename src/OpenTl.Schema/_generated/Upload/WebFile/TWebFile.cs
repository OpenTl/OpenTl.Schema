// ReSharper disable All

namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x21e753bc)]
	public sealed class TWebFile : IWebFile
	{
       [SerializationOrder(0)]
       public int Size {get; set;}

       /// <summary>Binary representation for the 'MimeType' property</summary>
       [SerializationOrder(1)]
       public byte[] MimeTypeAsBinary { get => _MimeTypeAsBinary; set { _MimeType = Encoding.UTF8.GetString(value); _MimeTypeAsBinary = value; }}
       private byte[] _MimeTypeAsBinary;
       private string _MimeType;
       public string MimeType { get => _MimeType; set { MimeTypeAsBinary = Encoding.UTF8.GetBytes(value); _MimeType = value; }}

       [SerializationOrder(2)]
       public OpenTl.Schema.Storage.IFileType FileType {get; set;}

       [SerializationOrder(3)]
       public int Mtime {get; set;}

       [SerializationOrder(4)]
       public byte[] Bytes {get; set;}

	}
}
