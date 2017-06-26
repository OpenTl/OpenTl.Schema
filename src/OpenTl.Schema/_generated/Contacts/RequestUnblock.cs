// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe54100bd)]
    public class RequestUnblock : IRequest<bool>
    {
       [SerializationOrder(0)]
       public IInputUser Id {get; set;}

    }
}
