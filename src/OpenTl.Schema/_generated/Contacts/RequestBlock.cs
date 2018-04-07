// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x332b49fc)]
    public sealed class RequestBlock : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputUser Id {get; set;}

    }
}
