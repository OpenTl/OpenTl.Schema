// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9e3cacb0)]
    public sealed class RequestSearchGlobal : IRequest<OpenTl.Schema.Messages.IMessages>
    {
       /// <summary>Binary representation for the 'Q' property</summary>
       [SerializationOrder(0)]
       public byte[] QAsBinary { get => _QAsBinary; set { _Q = Encoding.UTF8.GetString(value); _QAsBinary = value; }}
       private byte[] _QAsBinary;
       private string _Q;
       public string Q { get => _Q; set { QAsBinary = Encoding.UTF8.GetBytes(value); _Q = value; }}

       [SerializationOrder(1)]
       public int OffsetDate {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IInputPeer OffsetPeer {get; set;}

       [SerializationOrder(3)]
       public int OffsetId {get; set;}

       [SerializationOrder(4)]
       public int Limit {get; set;}

    }
}
