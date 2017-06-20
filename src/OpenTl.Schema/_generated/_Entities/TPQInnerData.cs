namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x83c95aec)]
	public class TPQInnerData : IObject
	{
       [SerializationOrder(0)]
       public string Pq {get; set;}

       [SerializationOrder(1)]
       public string P {get; set;}

       [SerializationOrder(2)]
       public string Q {get; set;}

       [SerializationArrayLength(16)]
       [SerializationOrder(3)]
       public byte[] Nonce {get; set;}

       [SerializationArrayLength(16)]
       [SerializationOrder(4)]
       public byte[] ServerNonce {get; set;}

       [SerializationArrayLength(32)]
       [SerializationOrder(5)]
       public byte[] NewNonce {get; set;}

	}
}
