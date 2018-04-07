// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xdcbb8260)]
    public sealed class RequestGetHistory : IRequest<OpenTl.Schema.Messages.IMessages>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(1)]
       public int OffsetId {get; set;}

       [SerializationOrder(2)]
       public int OffsetDate {get; set;}

       [SerializationOrder(3)]
       public int AddOffset {get; set;}

       [SerializationOrder(4)]
       public int Limit {get; set;}

       [SerializationOrder(5)]
       public int MaxId {get; set;}

       [SerializationOrder(6)]
       public int MinId {get; set;}

       [SerializationOrder(7)]
       public int Hash {get; set;}

    }
}
