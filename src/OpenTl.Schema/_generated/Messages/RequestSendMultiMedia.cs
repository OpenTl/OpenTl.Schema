// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2095512f)]
    public sealed class RequestSendMultiMedia : IRequest<OpenTl.Schema.IUpdates>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 5)]
       public bool Silent {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 6)]
       public bool Background {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 7)]
       public bool ClearDraft {get; set;}

       [SerializationOrder(4)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 0)]
       public int ReplyToMsgId {get; set;}

       [SerializationOrder(6)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputSingleMedia> MultiMedia {get; set;}

    }
}
