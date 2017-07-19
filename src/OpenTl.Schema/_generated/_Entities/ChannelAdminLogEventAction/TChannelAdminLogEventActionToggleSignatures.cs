// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x26ae0971)]
	public class TChannelAdminLogEventActionToggleSignatures : IChannelAdminLogEventAction
	{
       [SerializationOrder(0)]
       public bool NewValue {get; set;}

	}
}
