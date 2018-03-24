// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IFound : IObject
    {
       OpenTl.Schema.TVector<OpenTl.Schema.IPeer> MyResults {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IPeer> Results {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IChat> Chats {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

    }
}
