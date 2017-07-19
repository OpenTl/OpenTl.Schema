// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbfd915cd)]
    public class RequestEditBanned : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public IInputChannel Channel {get; set;}

       [SerializationOrder(1)]
       public IInputUser UserId {get; set;}

       [SerializationOrder(2)]
       public IChannelBannedRights BannedRights {get; set;}

    }
}
