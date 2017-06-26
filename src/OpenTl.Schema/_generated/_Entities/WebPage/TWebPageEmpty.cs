// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xeb1477e8)]
	public class TWebPageEmpty : IWebPage
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

	}
}
