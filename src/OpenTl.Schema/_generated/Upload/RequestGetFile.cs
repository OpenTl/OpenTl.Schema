// ReSharper disable All

namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe3a6cfb5)]
    public sealed class RequestGetFile : IRequest<OpenTl.Schema.Upload.IFile>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputFileLocation Location {get; set;}

       [SerializationOrder(1)]
       public int Offset {get; set;}

       [SerializationOrder(2)]
       public int Limit {get; set;}

    }
}
