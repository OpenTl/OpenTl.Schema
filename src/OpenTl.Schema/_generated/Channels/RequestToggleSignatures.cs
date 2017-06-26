// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1f69b606)]
    public class RequestToggleSignatures : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public IInputChannel Channel {get; set;}

       [SerializationOrder(1)]
       public bool Enabled {get; set;}

    }
}
