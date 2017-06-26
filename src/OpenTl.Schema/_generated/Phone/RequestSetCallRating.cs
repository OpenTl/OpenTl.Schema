// ReSharper disable All

namespace OpenTl.Schema.Phone
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1c536a34)]
    public class RequestSetCallRating : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public IInputPhoneCall Peer {get; set;}

       [SerializationOrder(1)]
       public int Rating {get; set;}

       [SerializationOrder(2)]
       public string Comment {get; set;}

    }
}
