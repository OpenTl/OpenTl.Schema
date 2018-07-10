// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8514bdda)]
    public sealed class RequestToggleTopPeers : IRequest<bool>
    {
       [SerializationOrder(0)]
       public bool Enabled {get; set;}

    }
}
