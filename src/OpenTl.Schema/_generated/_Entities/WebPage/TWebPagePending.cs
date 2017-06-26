// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc586da1c)]
	public class TWebPagePending : IWebPage
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

       [SerializationOrder(1)]
       public int Date {get; set;}

	}
}
