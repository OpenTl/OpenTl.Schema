// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbddde532)]
	public sealed class TPeerChannel : IPeer
	{
       [SerializationOrder(0)]
       public int ChannelId {get; set;}

	}
}
