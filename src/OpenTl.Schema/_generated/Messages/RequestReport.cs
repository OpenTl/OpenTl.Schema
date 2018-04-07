// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbd82b658)]
    public sealed class RequestReport : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<int> Id {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IReportReason Reason {get; set;}

    }
}
