// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x22c6aa08)]
    public class RequestGetContacts : IRequest<Contacts.IContacts>
    {
       [SerializationOrder(0)]
       public string Hash {get; set;}

    }
}
