// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x11f812d8)]
    public class RequestSearch : IRequest<Contacts.IFound>
    {
       [SerializationOrder(0)]
       public string Q {get; set;}

       [SerializationOrder(1)]
       public int Limit {get; set;}

    }
}
