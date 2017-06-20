namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe9a734fa)]
	public class TPhotoCachedSize : IPhotoSize
	{
       [SerializationOrder(0)]
       public string Ype {get; set;}

       [SerializationOrder(1)]
       public IFileLocation Location {get; set;}

       [SerializationOrder(2)]
       public int W {get; set;}

       [SerializationOrder(3)]
       public int H {get; set;}

       [SerializationArrayLength(-1)]
       [SerializationOrder(4)]
       public byte[] Bytes {get; set;}

	}
}
