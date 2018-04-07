// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb6d45656)]
	public sealed class TUpdateChannel : IUpdate
	{
       [SerializationOrder(0)]
       public int ChannelId {get; set;}

	}
}
