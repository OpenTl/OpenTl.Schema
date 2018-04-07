// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5d7ceba5)]
	public sealed class TChannelAdminRights : IChannelAdminRights
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool ChangeInfo {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool PostMessages {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 2)]
       public bool EditMessages {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 3)]
       public bool DeleteMessages {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 4)]
       public bool BanUsers {get; set;}

       [SerializationOrder(6)]
       [FromFlag("Flags", 5)]
       public bool InviteUsers {get; set;}

       [SerializationOrder(7)]
       [FromFlag("Flags", 6)]
       public bool InviteLink {get; set;}

       [SerializationOrder(8)]
       [FromFlag("Flags", 7)]
       public bool PinMessages {get; set;}

       [SerializationOrder(9)]
       [FromFlag("Flags", 9)]
       public bool AddAdmins {get; set;}

       [SerializationOrder(10)]
       [FromFlag("Flags", 10)]
       public bool ManageCall {get; set;}

	}
}
