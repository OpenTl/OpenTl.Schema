// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb5890dba)]
	public sealed class TServerDHInnerData : IObject
	{
       [SerializationArrayLength(16)]
       [SerializationOrder(0)]
       public byte[] Nonce {get; set;}

       [SerializationArrayLength(16)]
       [SerializationOrder(1)]
       public byte[] ServerNonce {get; set;}

       [SerializationOrder(2)]
       public int G {get; set;}

       /// <summary>Binary representation for the 'DhPrime' property</summary>
       [SerializationOrder(3)]
       public byte[] DhPrimeAsBinary { get => _DhPrimeAsBinary; set { _DhPrime = Encoding.UTF8.GetString(value); _DhPrimeAsBinary = value; }}
       private byte[] _DhPrimeAsBinary;
       private string _DhPrime;
       public string DhPrime { get => _DhPrime; set { DhPrimeAsBinary = Encoding.UTF8.GetBytes(value); _DhPrime = value; }}

       /// <summary>Binary representation for the 'GA' property</summary>
       [SerializationOrder(4)]
       public byte[] GAAsBinary { get => _GAAsBinary; set { _GA = Encoding.UTF8.GetString(value); _GAAsBinary = value; }}
       private byte[] _GAAsBinary;
       private string _GA;
       public string GA { get => _GA; set { GAAsBinary = Encoding.UTF8.GetBytes(value); _GA = value; }}

       [SerializationOrder(5)]
       public int ServerTime {get; set;}

	}
}
