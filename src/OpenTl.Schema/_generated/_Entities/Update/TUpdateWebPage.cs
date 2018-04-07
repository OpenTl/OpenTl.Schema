// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x7f891213)]
	public sealed class TUpdateWebPage : IUpdate
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IWebPage Webpage {get; set;}

       [SerializationOrder(1)]
       public int Pts {get; set;}

       [SerializationOrder(2)]
       public int PtsCount {get; set;}

	}
}
