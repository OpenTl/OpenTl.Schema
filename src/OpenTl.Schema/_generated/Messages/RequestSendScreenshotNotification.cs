// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc97df020)]
    public class RequestSendScreenshotNotification : IRequest<IUpdates>
    {
       [SerializationOrder(0)]
       public IInputPeer Peer {get; set;}

       [SerializationOrder(1)]
       public int ReplyToMsgId {get; set;}

       [SerializationOrder(2)]
       public long RandomId {get; set;}

    }
}
