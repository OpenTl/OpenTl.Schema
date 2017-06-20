namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb6d45656)]
	public class TUpdateChannel : IUpdate
	{
       [SerializationOrder(0)]
       public int ChannelId {get; set;}

	}
}
