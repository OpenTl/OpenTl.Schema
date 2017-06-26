// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x4214f37f)]
	public class TUpdateReadChannelInbox : IUpdate
	{
       [SerializationOrder(0)]
       public int ChannelId {get; set;}

       [SerializationOrder(1)]
       public int MaxId {get; set;}

	}
}
