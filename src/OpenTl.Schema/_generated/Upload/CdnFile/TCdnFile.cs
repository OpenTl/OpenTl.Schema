// ReSharper disable All

namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa99fca4f)]
	public sealed class TCdnFile : ICdnFile
	{
       [SerializationOrder(0)]
       public byte[] Bytes {get; set;}

	}
}
