// ReSharper disable All

namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xeea8e46e)]
	public class TCdnFileReuploadNeeded : ICdnFile
	{
       [SerializationArrayLength(-1)]
       [SerializationOrder(0)]
       public byte[] RequestToken {get; set;}

	}
}
