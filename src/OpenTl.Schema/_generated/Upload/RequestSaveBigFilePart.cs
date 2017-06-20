namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xde7b673d)]
    public class RequestSaveBigFilePart : IRequest<bool>
    {
       [SerializationOrder(0)]
       public long FileId {get; set;}

       [SerializationOrder(1)]
       public int FilePart {get; set;}

       [SerializationOrder(2)]
       public int FileTotalParts {get; set;}

       [SerializationArrayLength(-1)]
       [SerializationOrder(3)]
       public byte[] Bytes {get; set;}

    }
}
