// ReSharper disable All

namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2e7a2020)]
    public class RequestReuploadCdnFile : IRequest<bool>
    {
       [SerializationOrder(0)]
       public byte[] FileToken {get; set;}

       [SerializationOrder(1)]
       public byte[] RequestToken {get; set;}

    }
}
