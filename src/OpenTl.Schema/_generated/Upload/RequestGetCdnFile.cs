namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2000bcc3)]
    public class RequestGetCdnFile : IRequest<Upload.ICdnFile>
    {
       [SerializationArrayLength(-1)]
       [SerializationOrder(0)]
       public byte[] FileToken {get; set;}

       [SerializationOrder(1)]
       public int Offset {get; set;}

       [SerializationOrder(2)]
       public int Limit {get; set;}

    }
}
