// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x42e047bb)]
	public class TChannelAdminLogEventActionDeleteMessage : IChannelAdminLogEventAction
	{
       [SerializationOrder(0)]
       public IMessage Message {get; set;}

	}
}
