// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IChannelAdminRights : IObject
    {
       BitArray Flags {get; set;}

       bool ChangeInfo {get; set;}

       bool PostMessages {get; set;}

       bool EditMessages {get; set;}

       bool DeleteMessages {get; set;}

       bool BanUsers {get; set;}

       bool InviteUsers {get; set;}

       bool InviteLink {get; set;}

       bool PinMessages {get; set;}

       bool AddAdmins {get; set;}

       bool ManageCall {get; set;}

    }
}
