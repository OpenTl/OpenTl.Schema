// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x55188a2e)]
	public class TChannelAdminLogEventActionChangeAbout : IChannelAdminLogEventAction
	{
       [SerializationOrder(0)]
       public string PrevValue {get; set;}

       [SerializationOrder(1)]
       public string NewValue {get; set;}

	}
}
