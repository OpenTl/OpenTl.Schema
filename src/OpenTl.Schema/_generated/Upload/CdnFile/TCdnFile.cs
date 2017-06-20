namespace OpenTl.Schema.Upload
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa99fca4f)]
	public class TCdnFile : ICdnFile
	{
       [SerializationArrayLength(-1)]
       [SerializationOrder(0)]
       public byte[] Bytes {get; set;}

	}
}
