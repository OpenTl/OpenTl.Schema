// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa32dd600)]
	public sealed class TMessageMediaWebPage : IMessageMedia
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IWebPage Webpage {get; set;}

	}
}
