namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa8f1709b)]
    public class RequestHideReportSpam : IRequest<bool>
    {
       [SerializationOrder(0)]
       public IInputPeer Peer {get; set;}

    }
}
