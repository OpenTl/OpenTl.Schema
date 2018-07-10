// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3c6a84d4)]
	public sealed class TPQInnerDataTemp : IPQInnerData
	{
       /// <summary>Binary representation for the 'Pq' property</summary>
       [SerializationOrder(0)]
       public byte[] PqAsBinary { get => _PqAsBinary; set { _Pq = Encoding.UTF8.GetString(value); _PqAsBinary = value; }}
       private byte[] _PqAsBinary;
       private string _Pq;
       public string Pq { get => _Pq; set { PqAsBinary = Encoding.UTF8.GetBytes(value); _Pq = value; }}

       /// <summary>Binary representation for the 'P' property</summary>
       [SerializationOrder(1)]
       public byte[] PAsBinary { get => _PAsBinary; set { _P = Encoding.UTF8.GetString(value); _PAsBinary = value; }}
       private byte[] _PAsBinary;
       private string _P;
       public string P { get => _P; set { PAsBinary = Encoding.UTF8.GetBytes(value); _P = value; }}

       /// <summary>Binary representation for the 'Q' property</summary>
       [SerializationOrder(2)]
       public byte[] QAsBinary { get => _QAsBinary; set { _Q = Encoding.UTF8.GetString(value); _QAsBinary = value; }}
       private byte[] _QAsBinary;
       private string _Q;
       public string Q { get => _Q; set { QAsBinary = Encoding.UTF8.GetBytes(value); _Q = value; }}

       [SerializationArrayLength(16)]
       [SerializationOrder(3)]
       public byte[] Nonce {get; set;}

       [SerializationArrayLength(16)]
       [SerializationOrder(4)]
       public byte[] ServerNonce {get; set;}

       [SerializationArrayLength(32)]
       [SerializationOrder(5)]
       public byte[] NewNonce {get; set;}

       [SerializationOrder(6)]
       public int ExpiresIn {get; set;}

	}
}
