// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xeb1477e8)]
	public sealed class TWebPageEmpty : IWebPage, IEmpty
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

	}
}
