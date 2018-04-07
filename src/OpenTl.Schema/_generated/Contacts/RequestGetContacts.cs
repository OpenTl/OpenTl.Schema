// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc023849f)]
    public sealed class RequestGetContacts : IRequest<OpenTl.Schema.Contacts.IContacts>
    {
       [SerializationOrder(0)]
       public int Hash {get; set;}

    }
}
