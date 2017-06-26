// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x49609307)]
    public class RequestToggleInvites : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public IInputChannel Channel {get; set;}

       [SerializationOrder(1)]
       public bool Enabled {get; set;}

    }
}
