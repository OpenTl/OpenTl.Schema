// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x40771900)]
	public class TUpdateChannelWebPage : IUpdate
	{
       [SerializationOrder(0)]
       public int ChannelId {get; set;}

       [SerializationOrder(1)]
       public IWebPage Webpage {get; set;}

       [SerializationOrder(2)]
       public int Pts {get; set;}

       [SerializationOrder(3)]
       public int PtsCount {get; set;}

	}
}
