// ReSharper disable All

namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xde7b673d)]
    public sealed class RequestSaveBigFilePart : IRequest<bool>
    {
       [SerializationOrder(0)]
       public long FileId {get; set;}

       [SerializationOrder(1)]
       public int FilePart {get; set;}

       [SerializationOrder(2)]
       public int FileTotalParts {get; set;}

       [SerializationOrder(3)]
       public byte[] Bytes {get; set;}

    }
}
