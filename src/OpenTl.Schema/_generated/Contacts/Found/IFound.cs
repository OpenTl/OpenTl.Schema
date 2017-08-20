// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IFound : IObject
    {
       TVector<IPeer> Results {get; set;}

       TVector<IChat> Chats {get; set;}

       TVector<IUser> Users {get; set;}

    }
}
