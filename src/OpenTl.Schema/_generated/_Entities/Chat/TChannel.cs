// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcb44b1c)]
	public class TChannel : IChat
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Creator {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 2)]
       public bool Left {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 5)]
       public bool Broadcast {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 7)]
       public bool Verified {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 8)]
       public bool Megagroup {get; set;}

       [SerializationOrder(6)]
       [FromFlag("Flags", 9)]
       public bool Restricted {get; set;}

       [SerializationOrder(7)]
       [FromFlag("Flags", 10)]
       public bool Democracy {get; set;}

       [SerializationOrder(8)]
       [FromFlag("Flags", 11)]
       public bool Signatures {get; set;}

       [SerializationOrder(9)]
       [FromFlag("Flags", 12)]
       public bool Min {get; set;}

       [SerializationOrder(10)]
       public int Id {get; set;}

       [SerializationOrder(11)]
       [CanSerialize("Flags", 13)]
       public long AccessHash {get; set;}

       [SerializationOrder(12)]
       public string Title {get; set;}

       [SerializationOrder(13)]
       [CanSerialize("Flags", 6)]
       public string Username {get; set;}

       [SerializationOrder(14)]
       public IChatPhoto Photo {get; set;}

       [SerializationOrder(15)]
       public int Date {get; set;}

       [SerializationOrder(16)]
       public int Version {get; set;}

       [SerializationOrder(17)]
       [CanSerialize("Flags", 9)]
       public string RestrictionReason {get; set;}

       [SerializationOrder(18)]
       [CanSerialize("Flags", 14)]
       public IChannelAdminRights AdminRights {get; set;}

       [SerializationOrder(19)]
       [CanSerialize("Flags", 15)]
       public IChannelBannedRights BannedRights {get; set;}

	}
}
