// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x15590068)]
	public sealed class TDocumentAttributeFilename : IDocumentAttribute
	{
       /// <summary>Binary representation for the 'FileName' property</summary>
       [SerializationOrder(0)]
       public byte[] FileNameAsBinary { get => _FileNameAsBinary; set { _FileName = Encoding.UTF8.GetString(value); _FileNameAsBinary = value; }}
       private byte[] _FileNameAsBinary;
       private string _FileName;
       public string FileName { get => _FileName; set { FileNameAsBinary = Encoding.UTF8.GetBytes(value); _FileName = value; }}

	}
}
