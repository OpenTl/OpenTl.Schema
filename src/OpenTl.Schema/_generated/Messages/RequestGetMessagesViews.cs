// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc4c8a55d)]
    public class RequestGetMessagesViews : IRequest<TVector<int>>
    {
       [SerializationOrder(0)]
       public IInputPeer Peer {get; set;}

       [SerializationOrder(1)]
       public TVector<int> Id {get; set;}

       [SerializationOrder(2)]
       public bool Increment {get; set;}

    }
}
