// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xafeb712e)]
	public class TInputChannel : IInputChannel
	{
       [SerializationOrder(0)]
       public int ChannelId {get; set;}

       [SerializationOrder(1)]
       public long AccessHash {get; set;}

	}
}
