// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe54100bd)]
    public sealed class RequestUnblock : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputUser Id {get; set;}

    }
}
