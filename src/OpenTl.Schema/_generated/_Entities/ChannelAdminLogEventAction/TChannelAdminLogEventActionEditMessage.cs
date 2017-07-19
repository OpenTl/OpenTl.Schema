// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x709b2405)]
	public class TChannelAdminLogEventActionEditMessage : IChannelAdminLogEventAction
	{
       [SerializationOrder(0)]
       public IMessage PrevMessage {get; set;}

       [SerializationOrder(1)]
       public IMessage NewMessage {get; set;}

	}
}
