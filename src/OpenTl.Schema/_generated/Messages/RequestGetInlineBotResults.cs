// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x514e999d)]
    public sealed class RequestGetInlineBotResults : IRequest<OpenTl.Schema.Messages.IBotResults>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputUser Bot {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.IInputGeoPoint GeoPoint {get; set;}

       /// <summary>Binary representation for the 'Query' property</summary>
       [SerializationOrder(4)]
       public byte[] QueryAsBinary { get => _QueryAsBinary; set { _Query = Encoding.UTF8.GetString(value); _QueryAsBinary = value; }}
       private byte[] _QueryAsBinary;
       private string _Query;
       public string Query { get => _Query; set { QueryAsBinary = Encoding.UTF8.GetBytes(value); _Query = value; }}

       /// <summary>Binary representation for the 'Offset' property</summary>
       [SerializationOrder(5)]
       public byte[] OffsetAsBinary { get => _OffsetAsBinary; set { _Offset = Encoding.UTF8.GetString(value); _OffsetAsBinary = value; }}
       private byte[] _OffsetAsBinary;
       private string _Offset;
       public string Offset { get => _Offset; set { OffsetAsBinary = Encoding.UTF8.GetBytes(value); _Offset = value; }}

    }
}
