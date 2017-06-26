// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb5890dba)]
	public class TServerDHInnerData : IObject
	{
       [SerializationArrayLength(16)]
       [SerializationOrder(0)]
       public byte[] Nonce {get; set;}

       [SerializationArrayLength(16)]
       [SerializationOrder(1)]
       public byte[] ServerNonce {get; set;}

       [SerializationOrder(2)]
       public int G {get; set;}

       [SerializationOrder(3)]
       public string DhPrime {get; set;}

       [SerializationOrder(4)]
       public string GA {get; set;}

       [SerializationOrder(5)]
       public int ServerTime {get; set;}

	}
}
