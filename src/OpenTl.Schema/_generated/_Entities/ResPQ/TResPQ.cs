// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x05162463)]
	public sealed class TResPQ : IResPQ
	{
       [SerializationArrayLength(16)]
       [SerializationOrder(0)]
       public byte[] Nonce {get; set;}

       [SerializationArrayLength(16)]
       [SerializationOrder(1)]
       public byte[] ServerNonce {get; set;}

       /// <summary>Binary representation for the 'Pq' property</summary>
       [SerializationOrder(2)]
       public byte[] PqAsBinary { get => _PqAsBinary; set { _Pq = Encoding.UTF8.GetString(value); _PqAsBinary = value; }}
       private byte[] _PqAsBinary;
       private string _Pq;
       public string Pq { get => _Pq; set { PqAsBinary = Encoding.UTF8.GetBytes(value); _Pq = value; }}

       [SerializationOrder(3)]
       public OpenTl.Schema.TVector<long> ServerPublicKeyFingerprints {get; set;}

	}
}
