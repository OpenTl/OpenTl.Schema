// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xad524315)]
	public class TImportedContacts : IImportedContacts
	{
       [SerializationOrder(0)]
       public TVector<IImportedContact> Imported {get; set;}

       [SerializationOrder(1)]
       public TVector<long> RetryContacts {get; set;}

       [SerializationOrder(2)]
       public TVector<IUser> Users {get; set;}

	}
}
