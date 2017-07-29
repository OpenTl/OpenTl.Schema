// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x77d01c3b)]
	public class TImportedContacts : IImportedContacts
	{
       [SerializationOrder(0)]
       public TVector<IImportedContact> Imported {get; set;}

       [SerializationOrder(1)]
       public TVector<IPopularContact> PopularInvites {get; set;}

       [SerializationOrder(2)]
       public TVector<long> RetryContacts {get; set;}

       [SerializationOrder(3)]
       public TVector<IUser> Users {get; set;}

	}
}
