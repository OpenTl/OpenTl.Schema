// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x37982646)]
	public sealed class TIpPortSecret : IIpPort
	{
       [SerializationOrder(0)]
       public int Ipv4 {get; set;}

       [SerializationOrder(1)]
       public int Port {get; set;}

       [SerializationOrder(2)]
       public byte[] Secret {get; set;}

	}
}
