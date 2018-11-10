// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[System.Serializable]
	[Serialize(0xc586da1c)]
	public sealed class TWebPagePending : IWebPage
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

       [SerializationOrder(1)]
       public int Date {get; set;}

	}
}
