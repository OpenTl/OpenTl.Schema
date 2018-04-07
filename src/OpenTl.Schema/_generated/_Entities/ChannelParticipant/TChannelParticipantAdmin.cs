// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa82fa898)]
	public sealed class TChannelParticipantAdmin : IChannelParticipant
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool CanEdit {get; set;}

       [SerializationOrder(2)]
       public int UserId {get; set;}

       [SerializationOrder(3)]
       public int InviterId {get; set;}

       [SerializationOrder(4)]
       public int PromotedBy {get; set;}

       [SerializationOrder(5)]
       public int Date {get; set;}

       [SerializationOrder(6)]
       public OpenTl.Schema.IChannelAdminRights AdminRights {get; set;}

	}
}
