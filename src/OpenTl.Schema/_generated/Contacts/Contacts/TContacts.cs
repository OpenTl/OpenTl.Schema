namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6f8b8cb2)]
	public class TContacts : IContacts
	{
       [SerializationOrder(0)]
       public TVector<IContact> Contacts {get; set;}

       [SerializationOrder(1)]
       public TVector<IUser> Users {get; set;}

	}
}
