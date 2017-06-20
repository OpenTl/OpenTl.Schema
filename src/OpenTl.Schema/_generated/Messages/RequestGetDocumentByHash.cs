namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x338e2464)]
    public class RequestGetDocumentByHash : IRequest<IDocument>
    {
       [SerializationArrayLength(-1)]
       [SerializationOrder(0)]
       public byte[] Sha256 {get; set;}

       [SerializationOrder(1)]
       public int Size {get; set;}

       [SerializationOrder(2)]
       public string MimeType {get; set;}

    }
}
