// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcd77d957)]
	public class TChannelMessagesFilter : IChannelMessagesFilter
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool ExcludeNewMessages {get; set;}

       [SerializationOrder(2)]
       public TVector<IMessageRange> Ranges {get; set;}

	}
}
