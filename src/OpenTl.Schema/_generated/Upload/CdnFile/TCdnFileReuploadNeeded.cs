// ReSharper disable All

namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xeea8e46e)]
	public sealed class TCdnFileReuploadNeeded : ICdnFile
	{
       [SerializationOrder(0)]
       public byte[] RequestToken {get; set;}

	}
}
