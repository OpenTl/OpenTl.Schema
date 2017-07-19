// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe9e82c18)]
	public class TChannelAdminLogEventActionUpdatePinned : IChannelAdminLogEventAction
	{
       [SerializationOrder(0)]
       public IMessage Message {get; set;}

	}
}
