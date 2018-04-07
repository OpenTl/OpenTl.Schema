// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5f5c95f1)]
	public sealed class TChannelAdminLogEventActionTogglePreHistoryHidden : IChannelAdminLogEventAction
	{
       [SerializationOrder(0)]
       public bool NewValue {get; set;}

	}
}
