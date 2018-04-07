// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8614ef68)]
    public sealed class RequestSearch : IRequest<OpenTl.Schema.Messages.IMessages>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       /// <summary>Binary representation for the 'Q' property</summary>
       [SerializationOrder(2)]
       public byte[] QAsBinary { get => _QAsBinary; set { _Q = Encoding.UTF8.GetString(value); _QAsBinary = value; }}
       private byte[] _QAsBinary;
       private string _Q;
       public string Q { get => _Q; set { QAsBinary = Encoding.UTF8.GetBytes(value); _Q = value; }}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.IInputUser FromId {get; set;}

       [SerializationOrder(4)]
       public OpenTl.Schema.IMessagesFilter Filter {get; set;}

       [SerializationOrder(5)]
       public int MinDate {get; set;}

       [SerializationOrder(6)]
       public int MaxDate {get; set;}

       [SerializationOrder(7)]
       public int OffsetId {get; set;}

       [SerializationOrder(8)]
       public int AddOffset {get; set;}

       [SerializationOrder(9)]
       public int Limit {get; set;}

       [SerializationOrder(10)]
       public int MaxId {get; set;}

       [SerializationOrder(11)]
       public int MinId {get; set;}

       [SerializationOrder(12)]
       public int Hash {get; set;}

    }
}
