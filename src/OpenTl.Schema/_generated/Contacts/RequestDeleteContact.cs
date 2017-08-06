// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8e953744)]
    public class RequestDeleteContact : IRequest<Contacts.ILink>
    {
       [SerializationOrder(0)]
       public IInputUser Id {get; set;}

    }
}
