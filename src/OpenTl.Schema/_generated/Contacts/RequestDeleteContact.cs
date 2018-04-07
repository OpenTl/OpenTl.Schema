// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8e953744)]
    public sealed class RequestDeleteContact : IRequest<OpenTl.Schema.Contacts.ILink>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputUser Id {get; set;}

    }
}
