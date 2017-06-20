namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9c750409)]
	public class TFoundGifCached : IFoundGif
	{
       [SerializationOrder(0)]
       public string Url {get; set;}

       [SerializationOrder(1)]
       public IPhoto Photo {get; set;}

       [SerializationOrder(2)]
       public IDocument Document {get; set;}

	}
}
