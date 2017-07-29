// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xfadff4ac)]
	public class TMessageFwdHeader : IMessageFwdHeader
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public int FromId {get; set;}

       [SerializationOrder(2)]
       public int Date {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public int ChannelId {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 2)]
       public int ChannelPost {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 3)]
       public string PostAuthor {get; set;}

	}
}
