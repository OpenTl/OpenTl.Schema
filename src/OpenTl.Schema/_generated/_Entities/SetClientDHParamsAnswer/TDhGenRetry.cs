// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x46dc1fb9)]
	public sealed class TDhGenRetry : ISetClientDHParamsAnswer
	{
       [SerializationArrayLength(16)]
       [SerializationOrder(0)]
       public byte[] Nonce {get; set;}

       [SerializationArrayLength(16)]
       [SerializationOrder(1)]
       public byte[] ServerNonce {get; set;}

       [SerializationArrayLength(16)]
       [SerializationOrder(2)]
       public byte[] NewNonceHash2 {get; set;}

	}
}
