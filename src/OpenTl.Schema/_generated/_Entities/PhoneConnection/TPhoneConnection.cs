// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9d4c17c0)]
	public class TPhoneConnection : IPhoneConnection
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

       [SerializationOrder(1)]
       public string Ip {get; set;}

       [SerializationOrder(2)]
       public string Ipv6 {get; set;}

       [SerializationOrder(3)]
       public int Port {get; set;}

       [SerializationArrayLength(-1)]
       [SerializationOrder(4)]
       public byte[] PeerTag {get; set;}

	}
}
