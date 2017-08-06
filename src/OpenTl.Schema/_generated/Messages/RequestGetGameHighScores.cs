// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe822649d)]
    public class RequestGetGameHighScores : IRequest<Messages.IHighScores>
    {
       [SerializationOrder(0)]
       public IInputPeer Peer {get; set;}

       [SerializationOrder(1)]
       public int Id {get; set;}

       [SerializationOrder(2)]
       public IInputUser UserId {get; set;}

    }
}
