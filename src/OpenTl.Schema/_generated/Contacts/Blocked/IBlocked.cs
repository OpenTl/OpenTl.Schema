// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IBlocked : IObject
    {
       TVector<IContactBlocked> Blocked {get; set;}

       TVector<IUser> Users {get; set;}

    }
}
