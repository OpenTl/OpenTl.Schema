// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x162ecc1f)]
	public class TFoundGif : IFoundGif
	{
       [SerializationOrder(0)]
       public string Url {get; set;}

       [SerializationOrder(1)]
       public string ThumbUrl {get; set;}

       [SerializationOrder(2)]
       public string ContentUrl {get; set;}

       [SerializationOrder(3)]
       public string ContentType {get; set;}

       [SerializationOrder(4)]
       public int W {get; set;}

       [SerializationOrder(5)]
       public int H {get; set;}

	}
}
