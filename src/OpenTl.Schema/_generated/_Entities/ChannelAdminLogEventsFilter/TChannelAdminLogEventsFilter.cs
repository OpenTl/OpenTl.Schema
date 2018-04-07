// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xea107ae4)]
	public sealed class TChannelAdminLogEventsFilter : IChannelAdminLogEventsFilter
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Join {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Leave {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 2)]
       public bool Invite {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 3)]
       public bool Ban {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 4)]
       public bool Unban {get; set;}

       [SerializationOrder(6)]
       [FromFlag("Flags", 5)]
       public bool Kick {get; set;}

       [SerializationOrder(7)]
       [FromFlag("Flags", 6)]
       public bool Unkick {get; set;}

       [SerializationOrder(8)]
       [FromFlag("Flags", 7)]
       public bool Promote {get; set;}

       [SerializationOrder(9)]
       [FromFlag("Flags", 8)]
       public bool Demote {get; set;}

       [SerializationOrder(10)]
       [FromFlag("Flags", 9)]
       public bool Info {get; set;}

       [SerializationOrder(11)]
       [FromFlag("Flags", 10)]
       public bool Settings {get; set;}

       [SerializationOrder(12)]
       [FromFlag("Flags", 11)]
       public bool Pinned {get; set;}

       [SerializationOrder(13)]
       [FromFlag("Flags", 12)]
       public bool Edit {get; set;}

       [SerializationOrder(14)]
       [FromFlag("Flags", 13)]
       public bool Delete {get; set;}

	}
}
