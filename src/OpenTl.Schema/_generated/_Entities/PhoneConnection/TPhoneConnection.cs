// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9d4c17c0)]
	public sealed class TPhoneConnection : IPhoneConnection
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

       /// <summary>Binary representation for the 'Ip' property</summary>
       [SerializationOrder(1)]
       public byte[] IpAsBinary { get => _IpAsBinary; set { _Ip = Encoding.UTF8.GetString(value); _IpAsBinary = value; }}
       private byte[] _IpAsBinary;
       private string _Ip;
       public string Ip { get => _Ip; set { IpAsBinary = Encoding.UTF8.GetBytes(value); _Ip = value; }}

       /// <summary>Binary representation for the 'Ipv6' property</summary>
       [SerializationOrder(2)]
       public byte[] Ipv6AsBinary { get => _Ipv6AsBinary; set { _Ipv6 = Encoding.UTF8.GetString(value); _Ipv6AsBinary = value; }}
       private byte[] _Ipv6AsBinary;
       private string _Ipv6;
       public string Ipv6 { get => _Ipv6; set { Ipv6AsBinary = Encoding.UTF8.GetBytes(value); _Ipv6 = value; }}

       [SerializationOrder(3)]
       public int Port {get; set;}

       [SerializationOrder(4)]
       public byte[] PeerTag {get; set;}

	}
}
