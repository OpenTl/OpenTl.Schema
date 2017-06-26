// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa32dd600)]
	public class TMessageMediaWebPage : IMessageMedia
	{
       [SerializationOrder(0)]
       public IWebPage Webpage {get; set;}

	}
}
