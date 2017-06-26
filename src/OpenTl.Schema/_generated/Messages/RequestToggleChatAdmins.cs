// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xec8bd9e1)]
    public class RequestToggleChatAdmins : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public int ChatId {get; set;}

       [SerializationOrder(1)]
       public bool Enabled {get; set;}

    }
}
