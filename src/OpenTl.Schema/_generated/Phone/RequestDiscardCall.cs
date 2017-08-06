// ReSharper disable All

namespace OpenTl.Schema.Phone
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x78d413a6)]
    public class RequestDiscardCall : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public IInputPhoneCall Peer {get; set;}

       [SerializationOrder(1)]
       public int Duration {get; set;}

       [SerializationOrder(2)]
       public IPhoneCallDiscardReason Reason {get; set;}

       [SerializationOrder(3)]
       public long ConnectionId {get; set;}

    }
}
