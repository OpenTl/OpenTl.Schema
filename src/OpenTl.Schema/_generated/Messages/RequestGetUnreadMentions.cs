// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x46578472)]
    public sealed class RequestGetUnreadMentions : IRequest<OpenTl.Schema.Messages.IMessages>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(1)]
       public int OffsetId {get; set;}

       [SerializationOrder(2)]
       public int AddOffset {get; set;}

       [SerializationOrder(3)]
       public int Limit {get; set;}

       [SerializationOrder(4)]
       public int MaxId {get; set;}

       [SerializationOrder(5)]
       public int MinId {get; set;}

    }
}
