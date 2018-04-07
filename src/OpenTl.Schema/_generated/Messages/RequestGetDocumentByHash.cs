// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x338e2464)]
    public sealed class RequestGetDocumentByHash : IRequest<OpenTl.Schema.IDocument>
    {
       [SerializationOrder(0)]
       public byte[] Sha256 {get; set;}

       [SerializationOrder(1)]
       public int Size {get; set;}

       /// <summary>Binary representation for the 'MimeType' property</summary>
       [SerializationOrder(2)]
       public byte[] MimeTypeAsBinary { get => _MimeTypeAsBinary; set { _MimeType = Encoding.UTF8.GetString(value); _MimeTypeAsBinary = value; }}
       private byte[] _MimeTypeAsBinary;
       private string _MimeType;
       public string MimeType { get => _MimeType; set { MimeTypeAsBinary = Encoding.UTF8.GetBytes(value); _MimeType = value; }}

    }
}
