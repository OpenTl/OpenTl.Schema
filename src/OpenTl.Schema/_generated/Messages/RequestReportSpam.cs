namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcf1592db)]
    public class RequestReportSpam : IRequest<bool>
    {
       [SerializationOrder(0)]
       public IInputPeer Peer {get; set;}

    }
}
