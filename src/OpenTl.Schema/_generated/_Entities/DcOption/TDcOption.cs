// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5d8c6cc)]
	public class TDcOption : IDcOption
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Ipv6 {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool MediaOnly {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 2)]
       public bool TcpoOnly {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 3)]
       public bool Cdn {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 4)]
       public bool Static {get; set;}

       [SerializationOrder(6)]
       public int Id {get; set;}

       [SerializationOrder(7)]
       public string IpAddress {get; set;}

       [SerializationOrder(8)]
       public int Port {get; set;}

	}
}
