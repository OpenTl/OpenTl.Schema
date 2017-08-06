// ReSharper disable All

namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1af91c09)]
    public class RequestReuploadCdnFile : IRequest<TVector<ICdnFileHash>>
    {
       [SerializationOrder(0)]
       public byte[] FileToken {get; set;}

       [SerializationOrder(1)]
       public byte[] RequestToken {get; set;}

    }
}
