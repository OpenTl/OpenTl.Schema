namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2e7a2020)]
    public class RequestReuploadCdnFile : IRequest<bool>
    {
       [SerializationArrayLength(-1)]
       [SerializationOrder(0)]
       public byte[] FileToken {get; set;}

       [SerializationArrayLength(-1)]
       [SerializationOrder(1)]
       public byte[] RequestToken {get; set;}

    }
}
