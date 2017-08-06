// ReSharper disable All

namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x24e6818d)]
    public class RequestGetWebFile : IRequest<Upload.IWebFile>
    {
       [SerializationOrder(0)]
       public IInputWebFileLocation Location {get; set;}

       [SerializationOrder(1)]
       public int Offset {get; set;}

       [SerializationOrder(2)]
       public int Limit {get; set;}

    }
}
