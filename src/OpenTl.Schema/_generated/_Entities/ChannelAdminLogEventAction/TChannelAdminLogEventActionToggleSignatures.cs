// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x26ae0971)]
	public sealed class TChannelAdminLogEventActionToggleSignatures : IChannelAdminLogEventAction
	{
       [SerializationOrder(0)]
       public bool NewValue {get; set;}

	}
}
