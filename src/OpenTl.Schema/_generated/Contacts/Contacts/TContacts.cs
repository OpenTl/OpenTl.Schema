// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6f8b8cb2)]
	public class TContacts : IContacts
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IContact> Contacts {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IUser> Users {get; set;}

	}
}
