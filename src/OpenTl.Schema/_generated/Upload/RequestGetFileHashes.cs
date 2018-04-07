// ReSharper disable All

namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc7025931)]
    public sealed class RequestGetFileHashes : IRequest<OpenTl.Schema.TVector<OpenTl.Schema.IFileHash>>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputFileLocation Location {get; set;}

       [SerializationOrder(1)]
       public int Offset {get; set;}

    }
}
