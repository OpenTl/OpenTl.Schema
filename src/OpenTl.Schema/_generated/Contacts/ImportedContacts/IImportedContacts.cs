// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IImportedContacts : IObject
    {
        TVector<IImportedContact> Imported {get; set;}

        TVector<IPopularContact> PopularInvites {get; set;}

        TVector<long> RetryContacts {get; set;}

        TVector<IUser> Users {get; set;}

    }
}
