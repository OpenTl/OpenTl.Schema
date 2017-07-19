// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x289da732)]
	public class TChannelForbidden : IChat
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 5)]
       public bool Broadcast {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 8)]
       public bool Megagroup {get; set;}

       [SerializationOrder(3)]
       public int Id {get; set;}

       [SerializationOrder(4)]
       public long AccessHash {get; set;}

       [SerializationOrder(5)]
       public string Title {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 16)]
       public int UntilDate {get; set;}

	}
}
