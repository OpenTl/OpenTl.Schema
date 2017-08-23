// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IImportedContacts : IObject
    {
       OpenTl.Schema.TVector<OpenTl.Schema.IImportedContact> Imported {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IPopularContact> PopularInvites {get; set;}

       OpenTl.Schema.TVector<long> RetryContacts {get; set;}

       OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

    }
}
