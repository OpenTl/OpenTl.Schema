// ReSharper disable All

namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb304a621)]
    public class RequestSaveFilePart : IRequest<bool>
    {
       [SerializationOrder(0)]
       public long FileId {get; set;}

       [SerializationOrder(1)]
       public int FilePart {get; set;}

       [SerializationArrayLength(-1)]
       [SerializationOrder(2)]
       public byte[] Bytes {get; set;}

    }
}
