// ReSharper disable All

namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe3a6cfb5)]
    public class RequestGetFile : IRequest<Upload.IFile>
    {
       [SerializationOrder(0)]
       public IInputFileLocation Location {get; set;}

       [SerializationOrder(1)]
       public int Offset {get; set;}

       [SerializationOrder(2)]
       public int Limit {get; set;}

    }
}
