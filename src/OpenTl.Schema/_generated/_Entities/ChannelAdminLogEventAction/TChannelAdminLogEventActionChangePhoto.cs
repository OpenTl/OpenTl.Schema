// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb82f55c3)]
	public sealed class TChannelAdminLogEventActionChangePhoto : IChannelAdminLogEventAction
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IChatPhoto PrevPhoto {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IChatPhoto NewPhoto {get; set;}

	}
}
