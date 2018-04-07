// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf57c350f)]
    public sealed class RequestGetBlocked : IRequest<OpenTl.Schema.Contacts.IBlocked>
    {
       [SerializationOrder(0)]
       public int Offset {get; set;}

       [SerializationOrder(1)]
       public int Limit {get; set;}

    }
}
