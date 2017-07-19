// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb82f55c3)]
	public class TChannelAdminLogEventActionChangePhoto : IChannelAdminLogEventAction
	{
       [SerializationOrder(0)]
       public IChatPhoto PrevPhoto {get; set;}

       [SerializationOrder(1)]
       public IChatPhoto NewPhoto {get; set;}

	}
}
