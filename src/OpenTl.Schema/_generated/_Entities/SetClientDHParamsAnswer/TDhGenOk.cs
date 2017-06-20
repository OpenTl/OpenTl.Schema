namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3bcbf734)]
	public class TDhGenOk : ISetClientDHParamsAnswer
	{
       [SerializationArrayLength(16)]
       [SerializationOrder(0)]
       public byte[] Nonce {get; set;}

       [SerializationArrayLength(16)]
       [SerializationOrder(1)]
       public byte[] ServerNonce {get; set;}

       [SerializationArrayLength(16)]
       [SerializationOrder(2)]
       public byte[] NewNonceHash1 {get; set;}

	}
}
