// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6153276a)]
	public class TChatPhoto : IChatPhoto
	{
       [SerializationOrder(0)]
       public IFileLocation PhotoSmall {get; set;}

       [SerializationOrder(1)]
       public IFileLocation PhotoBig {get; set;}

	}
}
