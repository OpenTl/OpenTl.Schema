// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x18b7a10d)]
	public sealed class TDcOption : IDcOption
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

       /// <summary>Binary representation for the 'IpAddress' property</summary>
       [SerializationOrder(7)]
       public byte[] IpAddressAsBinary { get => _IpAddressAsBinary; set { _IpAddress = Encoding.UTF8.GetString(value); _IpAddressAsBinary = value; }}
       private byte[] _IpAddressAsBinary;
       private string _IpAddress;
       public string IpAddress { get => _IpAddress; set { IpAddressAsBinary = Encoding.UTF8.GetBytes(value); _IpAddress = value; }}

       [SerializationOrder(8)]
       public int Port {get; set;}

       [SerializationOrder(9)]
       [CanSerialize("Flags", 10)]
       public byte[] Secret {get; set;}

	}
}
