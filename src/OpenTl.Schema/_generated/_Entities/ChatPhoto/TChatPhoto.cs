// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6153276a)]
	public sealed class TChatPhoto : IChatPhoto
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IFileLocation PhotoSmall {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IFileLocation PhotoBig {get; set;}

	}
}
