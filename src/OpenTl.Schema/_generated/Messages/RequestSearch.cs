namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd4569248)]
    public class RequestSearch : IRequest<Messages.IMessages>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public IInputPeer Peer {get; set;}

       [SerializationOrder(2)]
       public string Q {get; set;}

       [SerializationOrder(3)]
       public IMessagesFilter Filter {get; set;}

       [SerializationOrder(4)]
       public int MinDate {get; set;}

       [SerializationOrder(5)]
       public int MaxDate {get; set;}

       [SerializationOrder(6)]
       public int Offset {get; set;}

       [SerializationOrder(7)]
       public int MaxId {get; set;}

       [SerializationOrder(8)]
       public int Limit {get; set;}

    }
}
